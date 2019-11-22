using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Departure
    {
        //random time
        //random rutes
        //Airplane
        public void GatherDepartureInformation()
        {
            //SimulatedDepartureTime sdp = new SimulatedDepartureTime();

            //DateTime ranDepartureTime = sdp.DepartureTime();

            string connString = @"Server=(localdb)\MSSQLLocalDB;Database=AirportDB;Trusted_Connection = True;";
            
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT Airline.Name, Rute.FromLocation, Rute.Destination FROM Airline JOIN Rute ON Airline.Name = Rute.OwnerOfRute";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        
                        for (int i = 0; i < dr.VisibleFieldCount; i++)
                        {
                            Console.WriteLine("{0}{1}",SimulatedDepartureTime.Instance.DepartureTime(), dr.GetValue(i));
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                }

                conn.Close();

            }
        }

    }
}
