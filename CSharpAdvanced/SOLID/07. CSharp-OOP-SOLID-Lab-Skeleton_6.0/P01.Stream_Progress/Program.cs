using P01.Stream_Progress.Interfaces;
using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    IEngine engine = new Engine();
                    engine.Run();
                    break;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.ParamName);
                }
                catch (ArgumentOutOfRangeException exc)
                {
                    Console.WriteLine(exc.ParamName);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            } 
        }
    }
}
