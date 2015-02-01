using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal, ISound
    {
        public Dog(string dogName, decimal dogAge, Gender dogGender)
            : base(dogName, dogAge, dogGender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Dog {0} says \"Bau-bau!\"", this.Name);
        }
    }
}
