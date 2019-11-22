using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
   public sealed class SimulatedDepartureTime
    {
        SimulatedDepartureTime() 
        {
        
        }
        private static readonly object padlock = new object();
        private static SimulatedDepartureTime instance = null;
        public static SimulatedDepartureTime Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SimulatedDepartureTime();
                    }
                    return instance;
                }
            }
        }



        //private static readonly SimulatedDepartureTime instance = new SimulatedDepartureTime();
        //Randomizes a DateTime for the departures
        public DateTime DepartureTime()
        {
            int hour = RandomizedHour();
            DateTime Today = DateTime.Today.AddHours(hour);
            return Today;
            //Console.WriteLine("The current date and time: {0:dd/MM/ H:mm:ss zzz}",
            //       Today);
        }
        //This method randomizes and returns a number for time of day
        public int RandomizedHour()
        {
            Random ran = new Random();
            int randomnumber = ran.Next(0, 23);
            return randomnumber;
        }
  
    }
}
