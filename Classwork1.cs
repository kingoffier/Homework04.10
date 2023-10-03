using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string x = Console.ReadLine();
            Console.WriteLine("Введите любую цифру: ");
            string y = Console.ReadLine();
            int x1;
            int y1;
            bool p = int.TryParse(x, out x1);
            bool p1 = int.TryParse(y, out y1);
            if (p == true && p1 == true)
            {
                bool cn = x.Contains(y);
                if (cn == true)
                {
                    Console.WriteLine("yes");
                    int j = x.IndexOf(y);
                    Console.WriteLine("Позиция цифры: " + (j + 1));
                }
                else
                {
                    Console.WriteLine("no");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
