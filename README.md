# Unit-testing-C-Sharp

To begin unit testing: 
    1. Change the directory to the unit-testing-using-dotnet-test folder.
        - cd unit-testing-using-dotnet-test
    2. Begin unit test
        - dotnet test

By default the unit tests should pass. 

In the file unit-testing-using-dotnet-test/PrimeService_IsPrimeShould.cs, we have two methods for testing PrimeService.IsPrime()
    1. IsPrime_ReturnTrue()
        - Passes if all inputs of IsPrime are prime
    2. IsNotPrime_ReturnFalse()
        - Passes if all inputs of IsPrime are not prime

To test the failing conditions for each method, un-comment the last [InlineData] attribute for each method or add your own test cases

