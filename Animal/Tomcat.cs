using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string tomcatName, decimal tomcatAge)
            : base(tomcatName, tomcatAge, Gender.male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Tomcat {0} says \"RRRRRRRRRRRRRRR!\"", this.Name);
        }
    }
}
