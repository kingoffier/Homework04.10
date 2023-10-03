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
           while (x.Contains("  "))
           {
               x = x.Replace("  ", " ");
           }
           x = x.Trim();
           string[] rez;
           rez = x.Split(' ');
           int x1;
           int x2;
           int x4 = x.Length;
           bool p = int.TryParse(rez[0], out x1);
           bool p1 = int.TryParse(rez[1], out x2);
           int x3 = x1 * x2;
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
