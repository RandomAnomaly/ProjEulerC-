using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Prime_Factor
{
    class Program
    {


        /**
         * You can do this by keeping three variables:

            The number you are trying to factor (A)
            A current divisor store (B)
            A largest divisor store (C)
            Initially, let (A) be the number you are interested in - in this case, it is 600851475143.
            Then let (B) be 2. Have a conditional that checks if (A) is divisible by (B).
            If it is divisible, divide (A) by (B), reset (B) to 2, and go back to checking if (A) is divisible by (B).
            Else, if (A) is not divisible by (B), increment (B) by +1 and then check if (A) is divisible by (B).
            Run the loop until (A) is 1. The (3) you return will be the largest prime divisor of 600851475143.*/
        static void Main(string[] args)
        {
            long a = 600851475143;
            long b = 2;
            long c = 0;

            while(a > 1)
            {
                if(a % b == 0)
                {
                    Console.WriteLine("Divisor found: " + b);
                    a /= b;
                    c = b;
                    b = 2;
                }
                else
                {
                    b++;
                }
            }
            Console.WriteLine("Greatest Prime Factor: " + c);
            new Program().delayClose();
        }

        void delayClose()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }
    }
}
