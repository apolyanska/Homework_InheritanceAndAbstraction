using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SchoolClass : IDetails
    {
        private string textIdentifier;
        private List<Student> classStudents;
        private List<Teacher> classTeachers;
        public string Details { get; set; }

        public SchoolClass(string textIdentifier, List<Student> classStudents, List<Teacher> classTeachers)
        {
            this.TextIdentifier = textIdentifier;
            this.ClassStudents = classStudents;
            this.ClassTeachers = classTeachers;
        }
        public SchoolClass(string textIdentifier, List<Student> classStudents, List<Teacher> classTeachers, string details)
            : this(textIdentifier, classStudents, classTeachers)
        {
            this.Details = details;
        }
        
        public string TextIdentifier
        {
           get {return this.textIdentifier;}
            
            set
            {
             if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Text identifier cannot be empty!");
                }
             this.textIdentifier = value;
            }
           
        }
        public List<Student> ClassStudents
        {
            get { return this.classStudents; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Text list of students cannot be empty!");
                }
                this.classStudents = value;
            }

        }
        public List<Teacher> ClassTeachers
        {
            get { return this.classTeachers; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Text list of teachers cannot be empty!");
                }
                this.classTeachers = value;
            }

        }
    }
}
