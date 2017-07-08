using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, S, P;
            Console.WriteLine("Введите длину первого катета: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второго катета");
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Sqrt(a * a + b * b);
            S = a * b / 2;
            P = a + b + c;
            Console.WriteLine("Гипотенуза равна {0}", c);
            Console.WriteLine("Площадь равна {0}", S);
            Console.WriteLine("Периметр равен {0}", P);
            Console.Read();

        }
    }
}