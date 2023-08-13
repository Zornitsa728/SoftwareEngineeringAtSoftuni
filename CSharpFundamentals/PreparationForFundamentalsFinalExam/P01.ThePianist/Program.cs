namespace P01.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();

            for (int i = 0; i < n; i++)
            {
                string[] currPiece = Console.ReadLine()
                    .Split('|');
                string pieceName = currPiece[0];
                string composer = currPiece[1];
                string key = currPiece[2];
                Piece piece = new Piece(pieceName, composer, key);
                pieces.Add(piece);
            }

            string cmd = string.Empty;

            while ((cmd = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = cmd
                    .Split('|');
                string operation = cmdArgs[0];
                string pieceName = cmdArgs[1];

                if (operation == "Add")
                {
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];

                    if (IsPieceExisting(pieceName, pieces))
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                    else
                    {
                        Piece piece = new Piece(pieceName, composer, key);
                        pieces.Add(piece);
                        Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                    }
                    
                }
                else if (operation == "Remove")
                {
                    if (IsPieceExisting(pieceName, pieces))
                    {
                        pieces.Remove(pieces.Find(x => x.PieceName == pieceName));
                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (operation == "ChangeKey")
                {
                    string newKey = cmdArgs[2];

                    if (IsPieceExisting(pieceName, pieces))
                    {
                        pieces.First(x => x.PieceName == pieceName).Key = newKey;
                        Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
            }

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.PieceName} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }

        static bool IsPieceExisting(string pieceName, List<Piece> pieces)
        {
            if (pieces.Any(x => x.PieceName == pieceName))
            {
                return true;
            }

            return false;
        }
    }

    public class Piece
    {
        public Piece(string pieceName, string composer, string key)
        {
            PieceName = pieceName;
            Composer = composer;
            Key = key;
        }
        public string PieceName { get; set; }

        public string Composer { get; set; }

        public string Key { get; set; }
    }
}