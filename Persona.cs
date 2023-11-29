using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights_database
{
    internal class Persona
    {
        private string name;
        private int age;
        private int id;

        public Persona(string n, int a, int i)
        {
            name = n;
            age = a;
            id = i;
        }

        public void SetName(string n)
        {
            name = n;
        }
        public void SetAge(int a)
        {
            age = a;
        }
        public void SetId(int a)
        {
            id = a;
        }

        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public int GetId()
        {
            return id;
        }
    }
}
