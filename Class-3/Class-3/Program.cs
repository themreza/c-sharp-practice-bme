using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3
{
    public struct s
    {
        public string name;
        public int num;
    }

    class Program
    {
        static s[] mystruct = new s[3];
        static void fillstruct(s[] inputstruct)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Name: ");
                inputstruct[i].name = Console.ReadLine();
                Console.Write("Number: ");
                inputstruct[i].num = int.Parse(Console.ReadLine());
            }
        }

        static double avg()
        {
            double sum = 0;
            for (int i = 0; i < 3; i++) sum = sum + mystruct[i].num;
            return sum/3;
        }

        static void Main(string[] args)
        {
            fillstruct(mystruct);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name: {0}", mystruct[i].name);
                Console.WriteLine("Number: {0}", mystruct[i].num);
            }
            Console.WriteLine("Sum of numbers: {0}", avg());
        }
    }
}
