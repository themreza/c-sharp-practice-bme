using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2
{
    class Program
    {
        // The "ref" keyword will use and modify the original variable passed to the function.
        // Not using it will create a copy of the input arguments in the memory.
        static void ReadVar(ref int x, ref int y)
        {
            Console.Write("A=");
            x = int.Parse(Console.ReadLine());
            Console.Write("B=");
            y = int.Parse(Console.ReadLine());
        }

        static void ReadVar2(string s, ref int x)
        {
            Console.Write(s);
            x = int.Parse(Console.ReadLine());
        }

        static int ReadVar3(string s)
        {
            int a; // Local variable a
            Console.Write(s);
            a = int.Parse(Console.ReadLine());
            return a;
        }

        static int plus(int a, int b)
        {
            return a + b;
        }

        static void prnt(int c)
        {
            Console.WriteLine("A+B={0}", c);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int a = 0, b = 0, c;
            //ReadVar(ref a, ref b);
            //ReadVar2("A=", ref a);
            //ReadVar2("B=", ref b);
            a = ReadVar3("A=");
            b = ReadVar3("B=");
            c = plus(a, b);
            prnt(c);
        }
    }
}
