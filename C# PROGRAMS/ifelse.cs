using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -2,b=7;
            if (a > 0)
            {
                Console.WriteLine("Psitive Number");
            }
            else if (a < 0)
                Console.WriteLine("Negative Number");
            else
                Console.WriteLine("Zero");

           switch(b)
            {
                case 1:
                    Console.WriteLine("Positive Number");
                    break;
                case 2:
                    Console.WriteLine("Negative Number");
                    break;
                default:
                    Console.WriteLine("Zero");
                    break;

            }

            //loop statement

            Console.WriteLine("Enter the number in the table:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);

            int m = 150;

            do
            {
                Console.WriteLine("{0} is grater than 100", m);
                m = m - 10;
            } while (m > 100);

            int n = 10;
            while(n<100)
            {
                Console.WriteLine("{0} is smaller than 100", n);
                n = n + 10;
            }

            int fact = 1, fn;
            Console.WriteLine("Enter a number to find its factorial");
            fn = int.Parse(Console.ReadLine());
            for (int i = 1; i <= fn; i++)
                fact = fact * i;
            Console.WriteLine("The factorial of {0} = {1}", fn, fact);
            Console.ReadKey();
        }
    }
}
