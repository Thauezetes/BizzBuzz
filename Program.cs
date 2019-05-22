using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Numdig, M3, M5, MM;
            int i;
            Console.Write("Digite um número: ");
            Numdig = Convert.ToDouble(Console.ReadLine());


            for (i = 1; i <= Numdig; i++)
            {

                M3 = i % 3;
                M5 = i % 5;
                MM = M3 + M5;

                if (MM == 0)
                {
                    Console.WriteLine("BizzBuzz");

                }
                else if (M3 == 0)
                {
                    Console.WriteLine("Bizz");
                }
                else if (M5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();

        }

    }
}
