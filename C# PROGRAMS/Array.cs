using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the Size of array:");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            int[] mark=new int[size];
            for (i = 0; i < size; i++)
                mark[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            string[] arr = new string[5];
            for (i = 0; i < 5; i++)
                arr[i] = Console.ReadLine();
            Console.WriteLine("\n");


            for (i=0;i<size;i++)
            Console.WriteLine("{0}",mark[i]);
            Console.WriteLine("\n");


            for (i = 0; i < 5; i++)
                Console.WriteLine("{0}", arr[i]);
            Console.WriteLine("\n");


            var res = Avg(mark,size);
            Console.WriteLine("The average is {0}", res);

            Console.ReadKey();


        }

        public static int Avg(int[] mark,int size)
        {
            int ans=0;
            for (int i = 0; i < size; i++)
                ans=ans+mark[i];
            int ans1;
            ans1 = ans / size;
            return ans1;
        }
    }
}
