using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCom
{
    public class Product
    {
        public int Prd_Id { get; set; }
        public string Prd_Name { get; set; }
        public double Price { get; set; }

        public double Total_Price(double rs, double tax)
        {
            var totprice = rs + tax;
            return totprice;
        }

        public double Discount(double tp)
        {
            var Fprice = tp - 50;
            return Fprice;
        }

        public String Showdata()
        {
            return String.Format("Product Id : {0} \nProduct Nmae : {1} \nPrice : {2}", Prd_Id, Prd_Name, Price);
        }
    }
}
