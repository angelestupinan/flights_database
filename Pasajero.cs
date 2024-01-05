using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights_database
{
    internal class Pasajero : Persona
    {
        private string flightCode;

        public Pasajero(string name, int age, int id, string flcd) 
        : base(name, age, id)
        {
            flightCode = flcd;
        }

        public string FlightCode
        { 
            get { return flightCode; }
            set { flightCode = value; }
        }
    }
}
