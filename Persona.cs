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

        public string Name 
        {
            get { return name; }    
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Id
        {
            get { return id; } 
            set { id = value;}
        }
    }
}
