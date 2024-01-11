using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
    public class Profesor: Osoba
    {
        public List<string> Subjects { get; set; }

        public Profesor(string ime, string prezime, int id) : base(ime, prezime, id)
        {
            Subjects = new List<string>();
        }
        public void AddGradeToStudent(int grade, Student student)
        {
            student.AddGrade(grade);
        }

        public void DisplayGrade(Student student)
        {
            student.Display();
        }

        public void DisplayAllGrades(List<Student> students)
        {
            foreach(Student s in students)
            {
                DisplayGrade(s);
            }
        }
    }
}
