using System;
using System.Diagnostics;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            stopwatch.Reset();
            stopwatch.Start();
            RngCrypto.RngGetRandomInt(128, 1000000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            RngCrypto.RngGetRandomChars(128, 1000000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            RngCrypto.RanGetRandomNumbers(128, 1000000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);




            Console.WriteLine("Hello Teacher!");
        }

        private static void TakeTime<T>(T input)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            RngCrypto.RngGetRandomChars(128, 10000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}