using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultitheadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1();
            //Method2();
            //Method3();

            Console.WriteLine("Main thread started");

            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("{0} is running now with ID : {1}", t.Name, t.ManagedThreadId);

            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            Thread t3 = new Thread(Method3);
            t1.Start();
            t2.Start();
            t3.Start();

            Thread te = new Thread(Program.test);
            te.Start(50);

            t1.Join();
            t2.Join();
            t3.Join();
            te.Join();

            
            Console.WriteLine("Main thread exited");

            //Thread ta = new Thread(Area);
            //ta.Start();

        }

        public static void Method1()
        {
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Method1 : {0}", i);
        }

        public static void Method2()
        {
            for (int i = 1; i <= 50; i++)
            {
                if(i==25)
                {
                    Thread.Sleep(5000);
                }
                Console.WriteLine("Method2 : {0}", i);
            }
               
        }

        public static void Method3()
        {
            for (int i = 1; i <= 100; i++)
                Console.WriteLine("Method3 : {0}", i);
        }

        public static void test(object max)
        {
            int j = Convert.ToInt32(max);
            for (int i = 1; i <= j; i++)
                Console.WriteLine("Test : {0}", i);
        }

        //public static void Area()
        //{
        //    double len, bre;
        //    len = double.Parse(Console.ReadLine());
        //    bre = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Area of rectangle is {0}", len * bre);
        //}
    }

   
}
