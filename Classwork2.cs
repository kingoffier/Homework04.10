using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x2, y2;
            Console.WriteLine("Введите первую сторону");
            string x = Console.ReadLine();
            Console.WriteLine("Введите вторую сторону");
            string y = Console.ReadLine();
            bool p = float.TryParse(x, out float x1);
            bool p1 = float.TryParse(y, out float y1);
            x = x.Trim();
            y = y.Trim();
            if (x.Length == 0 || y.Length == 0)
            {
                Console.WriteLine("Одна или обе строки пустые");
            }
            else
            {
                if (p == false && p1 == false)
                {
                    Console.WriteLine("Вы ввели не число");
                }
                else
                {
                    if (x.Contains(".") || y.Contains("."))
                    {
                        x2 = x.Replace(".", ",");
                        y2 = y.Replace(".", ",");
                        Console.WriteLine($"Площадь:  {Convert.ToSingle(x2) * Convert.ToSingle(y2)}");
                    }
                    else
                    {
                        if (x1 <= 0 || y1 <= 0)
                        {
                            Console.WriteLine("Число отрицательное или 0");
                        }
                        else
                        {
                            if (x.Contains(" ") || y.Contains(" "))
                            {
                                x2 = x.Replace(" ", "");
                                y2 = y.Replace(" ", "");
                            }

                            else
                            {
                                Console.WriteLine("Площадь: " + (x1 * y1));
                            }
                        }
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
