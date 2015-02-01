using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public abstract class Person : IDetails
    {
        private string name;
        public string Details { get; set; }

        protected Person(string name)
        {
            this.Name = name;
        }
        protected Person(string name, string details)
            : this(name)
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
                    throw new ArgumentNullException("Name cannot be empty!");
                }

                this.name = value;
            }
        }
        
    }
}
