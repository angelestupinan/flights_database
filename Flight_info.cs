﻿using System;
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

        public void SetDestination(string d)
        {
            destination=d;
        }
        public void SetFlight_Code(string c)
        {
            flight_code=c;
        }
        public void SetSeats(int s)
        {
            seats=s;
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

        public string GetDestination()
        {
            return destination;
        }        
        public string GetCode()
        {
            return flight_code;
        }
        public int GetSeats()
        {
            return seats;
        }
        public List<Pasajero> GetPassengers()
        {
            return pasajeros;
        }
    }
}
