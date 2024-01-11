using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
    public class Student: Osoba
    {
        public string Group { get; set; }
        public List<int> Grades { get; set; }

        public Student(string group, string name, string surname, int id): base(name, surname, id)
        {
            Group = group;
            Grades = new List<int>();
        }

        public void AddGrade(int grade) {
            Grades.Add(grade);
        }
        public void Display() {
            Console.WriteLine($"Ime:{Name}, Prezime:{Surname}, ID:{ID}, Razred:{Group}, Ocjena:{Grades}");
        }
    }
}
