using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arguments
{
    class Program
    {
        static void Main(string[] args)
        {

            object obj;
            int a = 10;
            obj = a;        //converting a value type into a referance type implicity - boxing
            int b=(int)a;   //unboxing converting a boxed type into a value type by explicity casting it.

            Console.WriteLine("The value of a and b is {0}, {1}", a, b);

            // Passing argument by value

            int i, j;
            i = 10;
            j = 20;
            Console.WriteLine("The value of i and j before function call= {0}, {1}", i, j);

            //passing arguments by reference

            double sum = ShowData(ref i, ref j);
            Console.WriteLine("The value of i and j after function call= {0}, {1}", i, j);
            Console.WriteLine("Sum  = {0}", sum);

            Console.ReadKey();

        }
        public static double ShowData(ref int i, ref int j)
        {
            double sum;
            i += 5;
            j += 5;
            sum = i + j;
            return sum;
        }

    }
}
