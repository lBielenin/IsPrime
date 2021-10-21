using static System.Console;

namespace IsPrime
{
    class Program
    {
        private static readonly PrimeGenerator _primeGenerator = new PrimeGenerator();

        static void Main(string[] args)
        {
            WriteLine("Welcome to Prime Generator");

            var numberOfPrimes = GetUserInput();

            WriteLine($"The first {numberOfPrimes} prime numbers are:");
            _primeGenerator.GeneratePrimes(numberOfPrimes).ForEach(num => WriteLine(num));

            WriteLine($"Press any key to exit application");

            ReadKey();

        }

        private static int GetUserInput()
        {
            int result = 0;
            var isValid = false;

            WriteLine("Provide valid number of primes");

            do
            {
                var input = ReadLine();

                if (int.TryParse(input, out int number))
                {
                    result = number;
                    isValid = true;
                }
                else
                {
                    WriteLine("Invalid input!");
                }
            }
            while (!isValid);

            return result;
        }
    }
}
