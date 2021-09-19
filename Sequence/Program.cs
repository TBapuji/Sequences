using System;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
        foreach(int primeNumber in PrimeNumber.Retrieve(30))
            Console.WriteLine(primeNumber);
        }
    }
}
