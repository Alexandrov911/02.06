using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.17 в
            int n = 12;
            double[] mas = new double[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1630, 1900) / 10.0;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("  ");

           
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i] / mas[0]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }

            Console.ReadKey();
        }
    }
}
