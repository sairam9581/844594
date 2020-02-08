using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LinkDataset
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlcon;
            SqlCommand sqlcom;
            SqlDataAdapter da;
            DataSet ds;
            string constring, qrystring;


            constring = "data source=BLT10138\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlcon = new SqlConnection(constring);
            sqlcon.Open();
            //string country = Console.ReadLine();
            qrystring = "select * from customers";
            sqlcom = new SqlCommand(qrystring, sqlcon);
            da = new SqlDataAdapter(sqlcom);
            ds = new DataSet();
            da.Fill(ds, "Customers Info");
            DataTable dt = ds.Tables["Customers Info"];
            var customers = from customer in dt.AsEnumerable()
                            where customer.Field<string>("Country") == "USA"
                            select new
                            {
                                custName = customer["ContactName"],
                                custID = customer["CustomerID"],
                                compName = customer["CompanyName"],
                                position = customer["ContactTitle"],
                                add = customer["Address"],
                                city = customer["City"],
                                reg = customer["Region"],
                                pcode = customer["PostalCode"],
                                coun = customer["Country"],
                                pon = customer["Phone"],
                                fax = customer["Fax"]


                            };
            var customers1 = from customer in dt.AsEnumerable()
                             select customer;
                            //{
                            //    custName = customer["ContactName"],
                            //    custID = customer["CustomerID"],
                            //    compName = customer["CompanyName"],
                            //    position = customer["ContactTitle"],
                            //    add = customer["Address"],
                            //    city = customer["City"],
                            //    reg = customer["Region"],
                            //    pcode = customer["PostalCode"],
                            //    coun = customer["Country"],
                            //    pon = customer["Phone"],
                            //    fax = customer["Fax"]


                            //};
            foreach (var i in customers1)
            {
                if (i["Country"].ToString()== "USA")
                {
                    Console.WriteLine("{0} ", i["City"]);
                }
            }

            sqlcon.Close();
        }
    }
}
