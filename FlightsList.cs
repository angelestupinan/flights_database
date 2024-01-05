using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights_database
{
    internal class FlightsList
    {
        private List<Flight_info> flight = new List<Flight_info>();
        

        public void AddFlight(Flight_info fl)
        {
            if (flight.Count == 0) 
            {
                flight.Add(fl);
                MessageBox.Show("Guardado");
            }
            else
            {
                for (int i = 0; i < flight.Count; i++)
                {
                    if (flight[i] != null && flight[i].Flight_Code == fl.Flight_Code)
                    {
                        MessageBox.Show("El código de vuelo ya existe, utilice otro");
                        MessageBox.Show(fl.Destination + fl.Pasajeros + fl.Flight_Code);
                        break;

                    }
                    if (flight[i] == null)
                    {
                        flight.Add(fl);
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
        }
        public Flight_info GetFlight_Info(string code)
        {
            IEnumerable<Flight_info> fl_list = from list in flight
                                               where list.Flight_Code == code.ToUpper() 
                                               select list;
            return fl_list.First();
        }
    }
}
