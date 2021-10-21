using System;
using System.Collections.Generic;
using System.Linq;


namespace IsPrime
{
    internal class PrimeGenerator
    {
        public List<int> GeneratePrimes(int numberOfPrimes)
        {
            List<int> primeNumbers = new() { 2 };
            int currentNumber = 3;
            while (primeNumbers.Count < numberOfPrimes)
            {
                double sqrt = Math.Sqrt(currentNumber);

                if(isWhole(sqrt))
                {
                    bool isPrime = true;

                    foreach(var prime in primeNumbers.Where(num => num <= (int)sqrt))
                    {
                        if (currentNumber % prime == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primeNumbers.Add(currentNumber);
                    }
                }

                currentNumber += 2;
            }
            return primeNumbers;
        }

        private bool isWhole(double num) => num % 1 == 0;
    }
}
