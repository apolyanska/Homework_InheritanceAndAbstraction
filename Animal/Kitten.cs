using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten: Cat
    {
             public Kitten(string kittenName, decimal kittenAge)
            : base(kittenName, kittenAge, Gender.female)
        {
        }

             public override void ProduceSound()
             {
                 Console.WriteLine("Kitten {0} says \"Meaw-meaw!\"", this.Name);
             }
    }
}
