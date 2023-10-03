using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string x = Console.ReadLine();
            x = x.Trim();
            if (x.Contains(" ")) 
            { 
             x=x.Replace(" ","");
            }
            int x1 = (x.Length);
            int x2 = x1/2;
            string y = x.Substring(0, x2);
            string y1 = x.Substring(x2);
            string y3 = new string(y1.Reverse().ToArray());
            if (y == y3)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
        }
    }
}
