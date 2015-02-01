using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dog, Frog, Cat, Kitten and Tomcat
namespace Animals
{
    public abstract class Animal
    {
       
        private string name;
        private decimal age;


        public Gender gender { get; set; }

        public Animal(string name, decimal age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.gender = gender;
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
        public decimal Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} is {1}, it is {2} years old and is {3}", this.Name, this.GetType().Name, this.Age, this.gender);
        }
        public virtual void ProduceSound()
        {
        }
    }
}
