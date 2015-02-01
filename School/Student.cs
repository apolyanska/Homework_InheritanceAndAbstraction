using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student: Person
    {
        private int classID;

        public Student(string name, int classID)
            : base(name)
        {
            this.ClassID = classID;
        }
        public Student(string name, int classID, string details)
            : base(name, details)
        {
            this.ClassID = classID;
        }
        public int ClassID
        {
            get { return this.classID; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Unique class number cannot be negative!");
                }
                this.classID = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} // {2}" , this.Name, this.ClassID, this.Details ?? "...");
        }
        
    }
}
