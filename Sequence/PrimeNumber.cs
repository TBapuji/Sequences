using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    public class PrimeNumber
    {
        public static List<int> Retrieve(int numberOfPrimeNumbers)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            int i = 1;
            bool assignPM = false;
            while(true)
            {
                i++;
                foreach(int primeNumber in primeNumbers)
                {
                    assignPM = true;
                    if(i % primeNumber == 0) { assignPM = false; break; }
                }
                if(assignPM) 
                { 
                    primeNumbers.Add(i);
                    if(primeNumbers.Count == numberOfPrimeNumbers) break;
                }
            }
            return primeNumbers;
        }
    }
}
