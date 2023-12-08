using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models.Booths;
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Core
{
    public class Controller : IController
    {
        private BoothRepository booths;
        public Controller()
        {
            booths = new BoothRepository();
        }
        public string AddBooth(int capacity)
        {
            int boothId = booths.Models.Count + 1;
            Booth booth = new Booth(boothId, capacity);

            booths.AddModel(booth);

            return $"Added booth number {boothId} with capacity {capacity} in the pastry shop!";
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            if (cocktailTypeName != "Hibernation" && cocktailTypeName != "MulledWine")
            {
                return string.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);
            }

            if (size != "Small" && size != "Middle" && size != "Large")
            {
                return string.Format(OutputMessages.InvalidCocktailSize, size);
            }

            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            ICocktail cocktail = booth.CocktailMenu.Models.FirstOrDefault(c => c.Name == cocktailName && c.Size == size);

            if (cocktail != null)
            {
                return string.Format(OutputMessages.CocktailAlreadyAdded, size, cocktailName);
            }

            if (cocktailTypeName == "Hibernation")
            {
                cocktail = new Hibernation(cocktailName, size);
            }
            else if (cocktailTypeName == "MulledWine")
            {
                cocktail = new MulledWine(cocktailName, size);
            }

            booth.CocktailMenu.AddModel(cocktail);

            return string.Format(OutputMessages.NewCocktailAdded, size, cocktailName, cocktailTypeName);
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            if (delicacyTypeName != "Gingerbread" && delicacyTypeName != "Stolen")
            {
                return string.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }

            IBooth booth = booths.Models.First(b => b.BoothId == boothId);
            IDelicacy delicacy = booth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == delicacyName);

            if (delicacy != null)
            {
                return string.Format(OutputMessages.DelicacyAlreadyAdded, delicacyName);
            }

            if (delicacyTypeName == "Gingerbread")
            {
                delicacy = new Gingerbread(delicacyName);
            }
            else
            {
                delicacy = new Stolen(delicacyName);
            }

            booth.DelicacyMenu.AddModel(delicacy);

            return string.Format($"{delicacyTypeName} {delicacyName} added to the pastry shop!");
        }

        public string BoothReport(int boothId)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            return booth.ToString();
        }

        public string LeaveBooth(int boothId)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            booth.Charge();
            booth.ChangeStatus();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Bill {booth.Turnover:f2} lv");
            sb.AppendLine($"Booth {boothId} is now available!");

            return sb.ToString().Trim();
        }

        public string ReserveBooth(int countOfPeople)
        {
            var sortedBooths = booths.Models.Where(b => b.IsReserved == false && b.Capacity >= countOfPeople).OrderBy(b => b.Capacity).OrderByDescending(b => b.BoothId).ToList();

            if (sortedBooths.Count == 0)
            {
                return string.Format(OutputMessages.NoAvailableBooth, countOfPeople);
            }
            else
            {
                IBooth reservedBooth = sortedBooths.First();
                booths.Models.First(b => b.BoothId == reservedBooth.BoothId).ChangeStatus();
                return string.Format(OutputMessages.BoothReservedSuccessfully, reservedBooth.BoothId, countOfPeople);
            }
        }

        public string TryOrder(int boothId, string order)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            string[] orderTokens = order.Split("/", StringSplitOptions.RemoveEmptyEntries);
            string itemTypeName = orderTokens[0];
            string itemName = orderTokens[1];
            int countOfOrderedPieces = int.Parse(orderTokens[2]);

            if (orderTokens.Length == 4)
            {
                string size = orderTokens[3];

                if (itemTypeName != "Hibernation" && itemTypeName != "MulledWine")
                {
                    return string.Format(OutputMessages.NotRecognizedType, itemTypeName);
                }

                if (!booth.CocktailMenu.Models.Any(c => c.Name == itemName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }

                ICocktail cocktail = booth.CocktailMenu.Models.FirstOrDefault(c => c.Name == itemName && c.Size == size);

                if (cocktail == null)
                {
                    return string.Format(OutputMessages.CocktailStillNotAdded, size, itemName);
                }
                else
                {
                    double amount = cocktail.Price * countOfOrderedPieces;
                    booth.UpdateCurrentBill(amount);
                    return string.Format(OutputMessages.SuccessfullyOrdered, boothId, countOfOrderedPieces, itemName);
                }
            }
            else
            {
                if (itemTypeName != "Gingerbread" && itemTypeName != "Stolen")
                {
                    return string.Format(OutputMessages.NotRecognizedType, itemTypeName);
                }

                IDelicacy delicacy = booth.DelicacyMenu.Models.FirstOrDefault(c => c.Name == itemName);

                if (delicacy == null)
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }
                else
                {
                    double amount = delicacy.Price * countOfOrderedPieces;
                    booth.UpdateCurrentBill(amount);
                    return string.Format(OutputMessages.SuccessfullyOrdered, boothId, countOfOrderedPieces, itemName);
                }
            }










            throw new NotImplementedException();
        }
    }
}
