using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.29 б
            Console.WriteLine("Введите длину массива n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(50, 70);
                Console.WriteLine(mas[i]);
            }
            double m = 0;
            for (int i = 0; i < n; i++)
            {
                m = m + Math.Pow(mas[i], 2);
            }
            Console.WriteLine(m);
            if (9999<m&&m<100000)
            {
                Console.WriteLine("сумма квадратов числа m пятизначное");
            }
            else
            {
                Console.WriteLine("сумма квадратов числа m не пятизначное");
            }
            Console.ReadKey();
        }
    }
}
