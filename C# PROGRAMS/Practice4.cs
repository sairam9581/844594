using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCom;

namespace Productkowshik
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product() { Prd_Id = 101, Prd_Name = "Praveen Milk", Price = 200 };

            var Details = pro.Showdata();
            Console.WriteLine(Details);

            var Total_Price=pro.Total_Price(200, 28);
            var Final_Price = pro.Discount(Total_Price);

            Console.WriteLine("Total Price: {0} \nPricu to paid : {1}", Total_Price, Final_Price);
            
        }
    }
}
