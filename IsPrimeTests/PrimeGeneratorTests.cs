using IsPrime;
using Xunit;

namespace IsPrimeTests
{
    public class PrimeGeneratorTests
    {
        [Fact]
        public void PrimeGenerator_ReturnsValideNumbers()
        {
            PrimeGenerator generator = new();

            var numberOfPrimes = 1000;

            var result = generator.GeneratePrimes(numberOfPrimes);

            Assert.Equal(TestData.PrimeNumbers, result);
        }
    }
}
