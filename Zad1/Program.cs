using System;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ravnatelj ravnatelj = new Ravnatelj("Marko", "Petričevič", 7437437);
            Student student = new Student("RI", "Ivan", "Ivic", 432423);
            ravnatelj.AddStudent(student);
            Profesor profesor = new Profesor("Luka", "Lukic", 234910);
            ravnatelj.AddProfesor(profesor);
            profesor.AddGradeToStudent(5,student);
            student.Display();

            Group group = new Group("PI");
            group.AddStudent(student);

            ravnatelj.DispLayStudentsGPA();
           
        }
    }
}
