using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will solve a second-degree quadratic equation of the form a*x^2 + b*x + c = 0.");
            Console.WriteLine("Please enter the values of coefficients:");

            double a = 0;
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out a);

            double b = 0;
            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out b);

            double c = 0;
            Console.Write("c = ");
            double.TryParse(Console.ReadLine(), out c);

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("All coefficients are set to 0. Nothing to solve.");
                    }
                    else
                    {
                        Console.WriteLine("The entered coefficients are not mathematically valid.");
                    }
                }
                else
                {
                    Console.WriteLine("There is only one real solution for the given coefficients.");
                    Console.WriteLine("Solution: x = {0:G}", -c / b);
                }
            }
            else
            {
                double D = b * b - 4 * a * c;
                if (D == 0)
                {
                    Console.WriteLine("There are two identical real solutions for the given coefficients.");
                    Console.WriteLine("Solutions: x_1,2 = {0:G}", -b / (2 * a));
                }
                else if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("There are two different real solutions for the given coefficients.");
                    Console.WriteLine("Solutions: x_1 = {0:G}, x_2 = {1:G}", x1, x2);
                }
                else
                {
                    double re = -b / (2 * a);
                    double im = Math.Sqrt(-D) / (2 * a);
                    Console.WriteLine("There are two complex solutions for the given coefficients.");
                    Console.WriteLine("Solutions: x_1 = {0:G} + {1:G} i, x_2 = {0:G} - {1:G} i", re, im);
                }
            }
            Console.ReadKey();
        }
    }
}
