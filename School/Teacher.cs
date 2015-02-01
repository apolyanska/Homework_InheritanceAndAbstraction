using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : Person
    {
        private List<Discipline> disciplineSet;
        public string Details { get; set; }

        public Teacher(string name, List<Discipline> disciplineSet)
            :base(name)
        {
            this.DisciplineSet = disciplineSet;
        }

        public Teacher(string name, List<Discipline> disciplineSet, string details)
            : base(name, details)
        {
            this.DisciplineSet = disciplineSet;
        }

        public List<Discipline> DisciplineSet
        {
            get { return this.disciplineSet; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Discipline set cannot be empty!");
                }
                this.disciplineSet = value;
            }
        }
    }
}
