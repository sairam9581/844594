using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly As = Assembly.Load("ProductCom");

            Type[] type = As.GetTypes();

            foreach(Type t in type)
            {
                Console.WriteLine("Name : {0}", t.Name);
                Console.WriteLine("Binary Type : {0}", t.BaseType);

                MethodInfo[] meth = t.GetMethods();
                foreach (MethodInfo m in meth)
                {
                    Console.WriteLine("Method name : {0}", m.Name);
                    Console.WriteLine("Return type : {0}", m.ReturnType);

                    ParameterInfo[] par = m.GetParameters();

                    foreach (ParameterInfo p in par)
                    {
                        Console.WriteLine("Parameter Name : {0}", p.Name);
                        Console.WriteLine("Parameter Type : {0}", p.ParameterType);
                        Console.WriteLine("--------------------");
                    }
                    Console.WriteLine("--------------------");
                }
                Console.WriteLine("--------------------");
            }

        }
    }
}
