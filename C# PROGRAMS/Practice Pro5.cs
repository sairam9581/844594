using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();

            numbers();

            string msg=  value(a, b);
            Console.WriteLine(msg);

            Console.ReadKey();
        }
        
       public static void numbers()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The Two Numbers are {0} and {1}", a, b);
        }

        public static string value(int a,string b)
        {
           return string.Format("Your Name is {0} and your age is {1}", b, a);
        }
    }
}
