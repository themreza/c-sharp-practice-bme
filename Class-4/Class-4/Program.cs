using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4
{
    class Program
    {
        static int[] a;

        static void fill(int num)
        {
            a = new int[num];
            Random r = new Random();
            Console.Write("Generated numbers: ");
            for (int i = 0; i < a.Length; i++) {
                a[i] = r.Next(100);
                Console.Write("{0}", a[i]);
                if(i == (a.Length-1))
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

       
        static int min()
        {
            int smallest = a[0];
            for (int i = 1; i < a.Length; i++) if (a[i] < smallest) smallest = a[i];
            return smallest;
        }

        static int max()
        {
            int largest = a[0];
            for (int i = 1; i < a.Length; i++) if (a[i] > largest) largest = a[i];
            return largest;
        }

        static double avg()
        {
            double sum = 0;
            for (int i = 1; i < a.Length; i++) sum = sum + a[i];
            sum -= min() + max();
            return Math.Round(sum / (a.Length - 2), 2);
        }

        static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to generate? ");
            int num = Int32.Parse(Console.ReadLine());
            fill(num);
            Console.WriteLine("The smallest number is {0}.", min());
            Console.WriteLine("The largest number is {0}.", max());
            Console.WriteLine("The average, excluding the minimum and maximum, is {0}.", avg());
        }
    }
}
