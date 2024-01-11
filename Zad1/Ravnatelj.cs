using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
    public class Ravnatelj : Osoba
    {
        public List<Profesor> Profesors { get; set; }
        public List<Student> Students { get; set; }

        public Ravnatelj(string ime, string prezime, int id) : base(ime, prezime, id)
        {
            Profesors = new List<Profesor>();
            Students = new List<Student>();
        }

        public void AddProfesor(Profesor profesor)
        {
            Profesors.Add(profesor);
        }

        public void RemoveProfesor(Profesor profesor)
        {
            Profesors.Remove(profesor);
        }


        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void DispLayStudentsGPA()
        {
            foreach (var student in Students)
            {
                student.Display();
            }
        }
    }
}
