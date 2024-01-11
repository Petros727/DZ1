using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
    public abstract class Osoba
    {
        public string Name { get; set; } 
        public string Surname { get; set; }
        public int ID { get; set; }

        public Osoba(string name, string surname, int id)
        {
            Name = name;
            Surname = surname;
            ID = id;
        }
    }
}
