using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace restaurantdb
{
    class Menu
    {
        public int Mid { get; set; }
        public string Mtype { get; set; }
        public string Mitem_name { get; set; }
        public double Mitem_price { get; set; }
        private static void SelectMethod()
        {
            string constr = @"  Data Source = BLT1072\SQLEXPRESS; Initial Catalog = StudentDb; Integrated Security = True";
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            con = new SqlConnection(constr);
            try
            {
                con.Open();

                // string QuerySelect = "select Rlic_no,Rname,Rloc,Rtype,Mtype,Mitem_name,Mitem_price from Restaurant full join Menu on Resturant.Rlic_no=Menu.Mid";
                string QuerySelect = "select * from Menu";

                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //  Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}