using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a school. In the school, there are classes of students. 
//•	Each class has a set of teachers. 
//•	Each teacher teaches a set of disciplines. 
//•	Students have name and unique class number. Classes have unique text identifier. Teachers have name. 
//Disciplines have name, number of lectures and students. Both teachers and students are people. Students, classes,
//teachers and disciplines have details (optional field).


namespace School
{
    class SchoolMain
    {
        static void Main(string[] args)
        {
            Student gencho = new Student("Gencho", 2, "не разбира от ООП");
            Student pencho = new Student("Pencho", 7);
            Student atanas = new Student("Atanas", 3, "can't do his homework");

         //   Console.WriteLine(gencho.Name + " " + gencho.Details);

            List<Student> mathStudents = new List<Student>{gencho, pencho, atanas};

            Discipline math = new Discipline("math", 10, mathStudents);
            foreach (Student mathStudent in mathStudents)
            {
             Console.WriteLine(mathStudent);
            }
            List<Discipline> mathCourse = new List<Discipline>{math};
            Person stud1 = new Student("Misho", 1);
            Console.WriteLine(stud1.Name);
            Teacher Ivanova = new Teacher("Ivanova", mathCourse);
            Console.WriteLine(Ivanova.DisciplineSet);
        }
    }
}
