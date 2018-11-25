using System;

namespace Csharp_Euler003
{
    class Program
    {
        static void Main(string[] args)
        {/*  Euler Challenge #3
                What is the largest prime factor of the number 600851475143 ?   
                https://projecteuler.net/problem=3  */

            int bigPrime = 1; long numBig = 600851475143;
            int currFactor = 2;
            while (numBig > 1)
            {
                if(numBig % currFactor == 0)
                {
                    numBig = numBig / currFactor;
                    if(currFactor > bigPrime){
                        bigPrime = currFactor;
                    }
                }
                else
                {
                    currFactor++;
                }
            }
            Console.WriteLine("Euler Challenge #3\n\nThe largest prime factor of the number 600851475143 = {0}.", bigPrime);
            Console.ReadLine();
        }
    }
}
