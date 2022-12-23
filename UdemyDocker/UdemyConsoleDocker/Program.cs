using System;

namespace UdemyConsoleDocker
{
    class Program
    {
        /// <summary>
        /// şimdi kodu yazdık build edicez.Build ettikten sonra tekrar klasörümü gel
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 1;

            while (i < 1000)
            {

                Console.WriteLine("Hello World!" + i);
                i++;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
