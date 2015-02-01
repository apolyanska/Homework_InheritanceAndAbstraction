using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Does not contain FindAvarigeAge method- is was to hard and too little time to find out all by myself how LINQ works!

namespace Animals
{
    public class AnimalMain
    {
        static void Main(string[] args)
        {
            Cat muca = new Kitten("Muca", 2.5m);
            Kitten cuca = new Kitten("Cuca", 10);
            Tomcat milko = new Tomcat("Milko", 7.2m);
            Cat tom = new Tomcat("Tom", 2);
           // Console.WriteLine(muca);
            Dog balkan = new Dog("Balkan", 1, Gender.male);
            Dog doncho = new Dog("Doncho", 5.5m, Gender.male);
            Dog goran = new Dog("Goran", 6.5m, Gender.male);
            Dog milena = new Dog("Milena", 10, Gender.female);
            Dog conka = new Dog("Conka", 15, Gender.female);

          //  Console.WriteLine(balkan);
           // balkan.ProduceSound();
          //  muca.ProduceSound();
            
            Frog lena = new Frog("Lena", 1.7m, Gender.female);
            Frog mima = new Frog("Mima", 2, Gender.female);
            Frog bogdan = new Frog("Bogdan", 0.7m, Gender.male);

           

            Cat[] cats = new Cat[4]{muca, cuca, milko, tom};
            Dog[] dogs = new Dog[5] { balkan, doncho, goran, milena, conka};
            Frog[] frogs = new Frog[3] { lena, mima, bogdan };
        }
    }
}
