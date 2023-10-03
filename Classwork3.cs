using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника через пробел");
            string x = Console.ReadLine();
            x = x.Trim();
            string[] rez;
            rez = x.Split(' ');
            int x4 = x.Length;
            int x1;
            int x2;
            bool p = int.TryParse(rez[0], out x1);
            bool p1 = int.TryParse(rez[1], out x2);
            int x3 = x1 * x2;
            Console.WriteLine(x4);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            if (x4 <= 3 && p == true && p1 == true)
            {
                Console.WriteLine("Площадь: " + x3);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();

        }
    }
}
