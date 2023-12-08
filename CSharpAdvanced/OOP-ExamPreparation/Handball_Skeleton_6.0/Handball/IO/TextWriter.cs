using Handball.IO.Contracts;
using System.IO;

namespace Handball.IO
{
    public class TextWriter : IWriter
    {
        private string path = "../../../output.txt";
        public void Write(string text)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(text);
            }
        }

        public void WriteLine(string text)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(text);
            }
        }
    }
}
