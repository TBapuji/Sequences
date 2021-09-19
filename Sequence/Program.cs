using System;
using System.Diagnostics;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPrimeNumbers = 30000;
            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine($"RetrieveWithArray {PrimeNumber.RetrieveWithArray(numberOfPrimeNumbers).Length}");
            //foreach(int primeNumber in PrimeNumber.RetrieveWithList(numberOfPrimeNumbers))
            //{ Console.WriteLine(primeNumber); }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.TotalSeconds.ToString());


            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            Console.WriteLine($"RetrieveWithList, Number {PrimeNumber.RetrieveWithList(numberOfPrimeNumbers).Count}");

            //foreach(int primeNumber in PrimeNumber.RetrieveWithArray(numberOfPrimeNumbers))
            //{ Console.WriteLine(primeNumber); }
            stopWatch2.Stop();
            Console.WriteLine(stopWatch2.Elapsed.TotalSeconds.ToString());

            Stopwatch stopWatch3 = new Stopwatch();
            stopWatch3.Start();
            Console.WriteLine($"RetrieveWithArray {PrimeNumber.RetrieveWithArray(numberOfPrimeNumbers).Length}");
            //foreach(int primeNumber in PrimeNumber.RetrieveWithList(numberOfPrimeNumbers))
            //{ Console.WriteLine(primeNumber); }
            stopWatch3.Stop();
            Console.WriteLine(stopWatch3.Elapsed.TotalSeconds.ToString());


            Stopwatch stopWatch4 = new Stopwatch();
            stopWatch4.Start();
            Console.WriteLine($"RetrieveWithList, Number {PrimeNumber.RetrieveWithList(numberOfPrimeNumbers).Count}");

            //foreach(int primeNumber in PrimeNumber.RetrieveWithArray(numberOfPrimeNumbers))
            //{ Console.WriteLine(primeNumber); }
            stopWatch4.Stop();
            Console.WriteLine(stopWatch4.Elapsed.TotalSeconds.ToString());
        }
    }
}
