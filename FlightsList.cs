using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights_database
{
    internal class FlightsList
    {
        private Flight_info[] flight = new Flight_info[100];
        

        public void AddFlight(Flight_info fl)
        {
            for (int i = 0;i<100;i++)
            {
                if (flight[i]==null)
                {
                    flight[i] = fl;
                    break;
                }
            }
        }
        public Flight_info GetFlight_Info(int id)
        {
            Flight_info f = null;
            for (int i = 0; i < 100; i++)
            {
                if (id == flight[i].GetNumber())
                {
                    f= flight[i];
                }
            }

           return f;
        }
    }
}
