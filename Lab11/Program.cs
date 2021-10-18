using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab11_StructEquation;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения 0=kx+b");
            try
            {
                Console.Write("Коэффициент k=");
                double coefK = Convert.ToDouble(Console.ReadLine());

                Console.Write("Коэффициент b=");
                double coefB = Convert.ToDouble(Console.ReadLine());

                double rootX;

                Equation equation = new Equation(coefK, coefB);

                equation.Root(coefK, coefB, out rootX);
                Console.WriteLine("Корень уравнения X={0:##########.00}", rootX);
            }
            catch (Exception)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            Console.ReadKey();
        }
    }

    
}