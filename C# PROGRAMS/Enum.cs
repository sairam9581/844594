using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        enum colours
            {
            red=1,
            blue,
            green
        };
        static void Main(string[] args)
        {
            Console.WriteLine("The Color red indicates {0}", (int)colours.red);
            Console.WriteLine("The Color blue indicates {0}", (int)colours.blue);
            Console.WriteLine("The Color green indicates {0}", (int)colours.green);

            Console.ReadKey();
        }
    }
}
