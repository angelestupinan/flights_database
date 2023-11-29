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
                    if (flight[i] != null)
                    {
                        MessageBox.Show("Guardado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Se ha alcanzado el limite de vuelos");
                    }
                    break;
                }
            }
        }
        public Flight_info GetFlight_Info(string code)
        {
            Flight_info f = new Flight_info("","",0);
            for (int i = 0; i < 100; i++)
            {
                if (flight[i] != null)
                {
                    if (code == flight[i].GetCode())
                    {
                        f = flight[i];
                        break;
                    }
                }
            }

           return f;
        }
    }
}
