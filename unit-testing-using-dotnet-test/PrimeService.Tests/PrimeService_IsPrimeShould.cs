using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        //[InlineData(15)]
        //To test failing input (non-prime integers), un-comment the above [InlineData(15)] 

        public void IsPrime_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"The inputed value should be prime. {value} is not prime");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        //[InlineData(13)] 
        //To test failing input (prime integers), un-comment the above [InlineData(13)]
        
        public void IsNotPrime_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"The inputed value should not be prime. {value} is prime");
        }
    }
}