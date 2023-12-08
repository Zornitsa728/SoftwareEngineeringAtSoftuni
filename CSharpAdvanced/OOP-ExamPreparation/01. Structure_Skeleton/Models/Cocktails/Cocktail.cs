using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;

namespace ChristmasPastryShop.Models.Cocktails
{
    public abstract class Cocktail : ICocktail
    {
        private string name;
        private double price;

        public Cocktail(string cocktailName, string size, double price)
        {
            Name = cocktailName;
            Size = size;
            Price = price;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }

                name = value;
            }
        }


        public string Size { get; private set; }

        public double Price
        {
            get { return price; }
            private set
            {
                if (this.Size == "Small")
                {
                    price = value * 1.0 / 3;
                }
                else if (this.Size == "Middle")
                {
                    price = value * 2.0 / 3;
                }
                else if (this.Size == "Large")
                {
                    price = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Size}) - {this.Price:f2} lv";
        }
    }
}
