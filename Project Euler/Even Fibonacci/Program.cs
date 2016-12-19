using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int total = 0;
            Console.WriteLine(1);
            Console.WriteLine(1);
            while(a + b < 4000000)
            {
                int newFib = a + b;
                
                if(b >= a)
                {
                    a = newFib;
                } else
                {
                    b = newFib;
                }
                if(newFib % 2 == 0)
                {
                    Console.WriteLine(newFib + "\t\t\tEven");
                    total += newFib;
                } else
                {
                    Console.WriteLine(newFib);
                }
                
            }

            Console.WriteLine("\n\n\tSum of even Fibonacci below 4,000,000: " + total);

            new Program().delayClose();
        }

        

        void delayClose()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }
    }
}
