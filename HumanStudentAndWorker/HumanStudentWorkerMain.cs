using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Define an abstract class Human holding a first name and a last name.
//•	Define a class Student derived from Human that has a field faulty number (5-10 digits / letters).
//•	Define a class Worker derived from Human with fields WeekSalary and WorkHoursPerDay and method MoneyPerHour()
//that returns the payment earned by hour by the worker. 
//•	Define the proper constructors and properties for the classes in your class hierarchy.
//•	Initialize a list of 10 students and sort them by faculty number in ascending order (use LINQ or OrderBy() 
//extension method). Initialize a list of 10 workers and sort them by payment per hour in descending order.
//•	Merge the lists and then sort them by first name and last name.


namespace HumanStudentAndWorker
{
    public class HumanStudentWorkerMain
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Tosho", "Toshev", "1TU23457643YT");
            Student stud2 = new Student("Gosho", "Goshev", "8TU2346756757643YT");
            Student stud3 = new Student("Pencho", "Penchev", "7TU23567457643YT");
            Student stud4 = new Student("Ivan", "Ivanov", "5TU234tyut57643YT");
            Student stud5 = new Student("Dafinka", "Dafinova", "6TU23gfh457643YT");
            Student stud6 = new Student("Keti", "Kateva", "4TU23454357643YT");
            Student stud7 = new Student("Petya", "Peteva", "TU23457645643YT");
            Student stud8 = new Student("Sasho", "Sashev", "TU2345764fg3YT");
            Student stud9 = new Student("Ginka", "Minkova", "3TU25673457643YT");
            Student stud10 = new Student("Minka", "Ginkova", "2TU23457687643YT");

            List<Student> students = new List<Student> 
            {
                stud1,
                stud2,
                stud3,
                stud4,
                stud5,
                stud6,
                stud7,
                stud8,
                stud9,
                stud10
            };
            List<Student> sortedStudents = students.OrderBy(st => st.FacultyNumber)
           .ToList();

            foreach (Student stud in sortedStudents)
            {
                Console.WriteLine(stud);
            } 
            Console.WriteLine();

            //Worker sasho = new Worker("sasho", "sashev", 50, 1);
            //Console.WriteLine(sasho.WeekSalary);
            //Console.WriteLine(sasho);

            Worker worker1 = new Worker("Tanas", "Tanasov", 150, 20);
            Worker worker2 = new Worker("Tanyo", "Tanev", 150.6m, 12.3m);
            Worker worker3 = new Worker("Vanyo", "Vanev", 1200.50m, 20);
            Worker worker4 = new Worker("Ceno", "Cenov", 400.45m, 23);
            Worker worker5 = new Worker("Tisho", "Tishev", 1550, 13.5m);
            Worker worker6 = new Worker("Keti", "Miteva", 3456, 10);
            Worker worker7 = new Worker("Sonya", "Piteva", 5150.89m, 12);
            Worker worker8 = new Worker("Canko", "Cankov", 17850, 23);
            Worker worker9 = new Worker("Penyo", "Penev", 150, 5);
            Worker worker10 = new Worker("Hristo", "Hristov", 567.9m, 13);

            List<Worker> workers = new List<Worker> 
             {
                 worker1,
                 worker2,
                 worker3,
                 worker4,
                 worker5,
                 worker6,
                 worker7,
                 worker8,
                 worker9,
                 worker10
             };

            List<Worker> sortedWorkers = workers.OrderByDescending(st => st.CalculateMoneyPerHour())
           .ToList();

            foreach (Worker worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }
             Console.WriteLine();

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            List<Human> sortedHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();

           foreach (Human human in sortedHumans)
           {
               Console.WriteLine(human);
           }
        }
    }
}
