using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//faculty number (5-10 digits / letters).

namespace HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentOutOfRangeException("Faculty number must contain at least 10 characters!");
                }
                foreach (char ch in value)
                {
                    if (!Char.IsLetterOrDigit(ch))
                    {
                        throw new ArgumentOutOfRangeException("Faculty number must contain only letters and digits!");
                    }
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Name: {0} {1}, No: {2}", this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
