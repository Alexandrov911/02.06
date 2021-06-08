using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.17 a
            int n = 12;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(163, 190);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }
            for (int i = 0; i < n; i++)
            {
                mas[i] = mas[i] * 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}
