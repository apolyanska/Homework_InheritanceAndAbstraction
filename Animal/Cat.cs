using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Cat : Animal, ISound
    {
        public Cat(string catName, decimal catAge, Gender catGender)
            : base(catName, catAge, catGender)
        {
        }

    }
}
