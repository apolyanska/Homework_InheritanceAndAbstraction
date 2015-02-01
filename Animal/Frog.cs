using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Frog : Animal, ISound
    {
        public Frog(string frogName, decimal frogAge, Gender frogGender)
            : base(frogName, frogAge, frogGender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("DFrog {0} says \"Kwak-kwak!\"", this.Name);
        }
    }
}
