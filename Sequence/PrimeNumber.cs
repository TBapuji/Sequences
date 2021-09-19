using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    public class PrimeNumber
    {
        public static int[] Retrieve(int numberOfPrimeNumbers)
        {
            int[] primeNumbers = new int[numberOfPrimeNumbers];
            primeNumbers[0] = 2;
            int i = 1;
            int j = 0;
            int p = 0;
            bool assignPM = false;
            while(true)
            {
                i++;
                for(int arrayIndex = 0; arrayIndex < primeNumbers.Length; arrayIndex++)
                {
                    assignPM = true;
                    p = primeNumbers[arrayIndex];
                    if(p == 0 ) { break; }
                    else if(i % p == 0) { assignPM = false; break; }
                    
                }
                if(assignPM) 
                {                    
                    if(j +1 >= numberOfPrimeNumbers) break;
                    j += 1;
                    primeNumbers[j] = i;
                }               
            }
            return primeNumbers;
        }
    }
}
