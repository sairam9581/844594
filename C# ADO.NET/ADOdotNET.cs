using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBConsole
{
    class Program

    {

        
        

        static void Main(string[] args)
        {
            SqlConnection sqlcon;
            SqlCommand sqlcmd;
            SqlDataReader dr;
            SqlDataAdapter da;
            DataSet ds;
            string goks, qry;


            goks = "data source=BLT10138\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(goks);

            sqlcon.Open();

            qry = "Select Distinct ProductName from Products";
            sqlcmd = new SqlCommand(qry, sqlcon);

            dr = sqlcmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Product Name : {0}",dr["ProductName"]);
            }

            dr.Close();
            sqlcon.Close();
        }
    }
}
