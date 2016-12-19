using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Project_Euler.Program();
            Console.WriteLine("Total is: " + program.sumOfMultiples());
            program.delayClose();
        }

        // Returns sum of multiples below 1000
        int sumOfMultiples()
        {
            int total = 0;
            for(int i = 0; i < 1000; i++)
            {
                if(i % 3 == 0)
                {
                    total += i;
                } else if(i % 5 == 0)
                {
                    total += i;
                }

            }
            return total;
        }

        void delayClose()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }
    }
}
