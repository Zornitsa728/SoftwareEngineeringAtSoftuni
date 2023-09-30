namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader firstText = new StreamReader(firstInputFilePath))
            {
                using (StreamReader secondText = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string firstine = "";
                        string secondLine = "";

                        while (true) 
                        {
                            if ((firstine = firstText.ReadLine()) != null)
                            {
                                writer.WriteLine(firstine);
                            }

                            if ((secondLine = secondText.ReadLine()) != null)
                            {
                                writer.WriteLine(secondLine);
                            }

                            if (firstine  == null && secondLine == null)
                            {
                                break;
                            }
                        }

                    }
                }
            }
        }
    }
}
