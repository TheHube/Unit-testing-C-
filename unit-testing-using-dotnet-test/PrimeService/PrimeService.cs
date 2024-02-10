using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            //Returns false if candidate is less than 2 (not prime)
            if (candidate < 2){
                return false;
            }

            //Returns false if candidate is even and not 2 (not prime)
            if (candidate % 2 == 0 && candidate != 2){
                return false;
            }

            int factors = 0; 

            //Returns false if candidate has more than 2 factors (not prime)
            for(int i = 1; i < Math.Sqrt(candidate); i+=2){
                if (candidate % i ==  0){
                    factors += 2;
                    if (factors > 2){
                        return false;
                    }
                }
            }

            //Returns true is candidate only has 2 factors (prime)
            if(factors == 2){
                return true;
            }

            throw new NotImplementedException("Not fully implemented.");
        }
    }
} 