using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.36 б
            Console.WriteLine("Введите длину массива n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(70, 140);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("числа меньше 100");
            for (int i = 0; i < n; i++)
            {
                if (mas[i] < 100)
                {
                    Console.WriteLine(mas[i]);
                }
            }
            Console.ReadKey();

        }
    }
}
