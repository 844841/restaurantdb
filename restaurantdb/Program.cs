using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace restaurantdb
{
    class Program
    {
        static void Main(string[] args)
        {

            Restaurant rt = new Restaurant();



            RestaurantDataLayer rd = new RestaurantDataLayer();





            Console.WriteLine("select your operation 1.inert\t 2.show \t ");

            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    rt.setData();
                    rd.InsertRestaurent(rt);
                    Console.WriteLine("succefully inserted");
                    break;
                case 2:
                    rd.ShowData(rt);
                    break;




                default:
                    Console.WriteLine("wrong choice");
                    break;

            }

            // while (ch <= 3) ;










            /* Restaurant rt = new Restaurant();

         rt.setData();

         RestaurentDataLayer rd = new RestaurentDataLayer();

         rd.InsertRestaurent(rt);
         rd.ShowData(rt);
         */






            /* Restaurant r = new Restaurant
             {
                 Rlic_no = 1007,
                 Rname = "apple",
                 Rloc = "hyd",
                 Rtype = "veg",    
             };*/


            // SelectMethod();
            // InsertMethod();



            /*  private static void SelectMethod()
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
                      string QuerySelect = "select * from Restaurant";

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
              }*/

            /*
                    private static void InsertMethod()
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
                            string QueryInsert = "insert into  Restaurant values(1006,'star','hyd','Non-veg')";

                            cmd = new SqlCommand(QueryInsert, con);
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
                    */

            Console.ReadKey();
        }
    }
}




