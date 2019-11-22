using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Program
    {

        static void Main(string[] args)
        {
            Departure departure = new Departure();

            //string connString = @"Server=(localdb)\MSSQLLocalDB;Database=AirportDB;Trusted_Connection = True;";
            //SimulatedDepartureTime simulatedTime = new SimulatedDepartureTime();

            //simulatedTime.DepartureTime();
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connString))
            //    {
            //        string query = "SELECT * from Rute";
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        conn.Open();
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        if (dr.HasRows)
            //        {
            //            while (dr.Read())
            //            {
            //                //display retrieved record (first column only/string value)
            //                Console.WriteLine(dr.GetString(1));
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("No data found.");
            //        }

            //        conn.Close();

            //    }
            //}
            //catch (Exception ex)
            //{
            //    //display error message
            //    Console.WriteLine("Exception: " + ex.Message);
            //}
            departure.GatherDepartureInformation();


            Console.ReadLine();
        }
    }
}
