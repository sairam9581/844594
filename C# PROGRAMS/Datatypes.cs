using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 234;
            short s = 99;
            int i = 3333;
            long l = 65432112;
            float f = 10.99f;
            double d = 65.999;
            decimal m = 9999.99m;
            Console.WriteLine("Values of {0},{1},{2},{3},{4},{5},{6}", b, s, i, l, f, d, m);

            DateTime dd = DateTime.Now;
            Console.WriteLine("The  current date is: {0}", dd);
            Console.WriteLine("The  current short date is: {0}", dd.ToShortDateString());
            Console.WriteLine("The  current long date is: {0}", dd.ToLongDateString());
            Console.WriteLine("The  current short time is: {0}", dd.ToLongTimeString());
            Console.WriteLine("The  current long time is: {0}", dd.ToShortTimeString());

            int a, a1;
            Console.WriteLine("Enter the value of first number:\n");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of second number:\n");
            a1 = int.Parse(Console.ReadLine());

            Add(a, a1);

            double res = Multiply(a, a1);
            Console.WriteLine("The product of {0} and {1} = {2}", a, a1, res);
            Console.ReadKey();
        }

        public static void Add(int a, int b)
        {
            double d = a + b;
            Console.WriteLine("The Sum of {0} is {1} = {2}", a, b, d);
        }
        public static double Multiply(int a, int b)
        {
            double d1 = a * b;
            return d1;
        }

    }
}
