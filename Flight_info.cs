using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights_database
{
    internal class Flight_info
    {

        private string destination;
        private string flight_code;
        private int seats;
        private List<Pasajero> pasajeros = new List<Pasajero>();

        public Flight_info(string d, string c, int s)
        {
            destination = d;
            flight_code = c;
            seats = s;
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public string Flight_Code
        {
            get { return flight_code; }
            set { flight_code = value; }
        }
        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }
        public List<Pasajero> Pasajeros
        {
            get { return pasajeros; }
        }

        //añade un elemento a la lista

        public void AddPassenger(Pasajero pas)
        {
            if (pasajeros.Count < seats)
            {
                pasajeros.Add(pas);
                MessageBox.Show("Agregado con exito");
            }
            else
            {
                MessageBox.Show("Ya no quedan asientos disponibles");
            }
        }
    }
}
