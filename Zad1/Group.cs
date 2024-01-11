using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
  public class Group
    {
        public string GroupName { get; set; }
        public List<Student> Students { get; set; }

        public Group(string groupName)
        {
            GroupName = groupName;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(Student student){
            Students.Remove(student);
        }
        public void DisplayGroupGrades()
        {
            foreach(var student in Students)
            {
                student.Display();
            }
        }
    }
}
