using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHnadler
{
    class Program
    {
        public delegate void deleg();
        public event deleg print;
        public void OnPrint()
        {
            Console.WriteLine("It printed");
        }
        public void show()
        {
            print();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print = new deleg(p.OnPrint);
            p.show();

        }
    }
}
