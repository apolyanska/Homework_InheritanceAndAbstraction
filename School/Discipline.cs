using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline: IDetails
    {
        private string name;
        private int numberOfLectures;
        private List<Student> students;
       public string Details { get; set; }

       public Discipline(string name, int numberOfLectures, List<Student> studentsList)
       {
           this.Name = name;
           this.NumberOfLectures = numberOfLectures;
           this.Students = studentsList;
       }

       public Discipline(string name, int numberOfLectures, List<Student> students, string details)
           : this(name, numberOfLectures, students)
       {
           this.Details = details;
       }

       public string Name
       {
           get { return this.name; }
           set
           {
               if (String.IsNullOrEmpty(value))
               {
                   throw new ArgumentException("Discipline name cannot be empty!");
               }
               this.name = value;
           }
       }
       public int NumberOfLectures 
       {
           get { return this.numberOfLectures; }
           set
           {
               if (value < 0)
               {
                   throw new ArgumentOutOfRangeException("The number of lectures cannot be negative!");
               }
               this.numberOfLectures = value;
           }
       }
       public List<Student> Students
       {
           get { return this.students; }
           set
           {
               if (value == null)
               {
                   throw new ArgumentException("List of students cannot be empty!");
               }
               this.students = value;
           }
       }
    }
}
