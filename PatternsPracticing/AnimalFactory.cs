using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPracticing
{
    public static class AnimalFactory
    {
        public static IAnimal GetAnimal(string clas, string type, string name, string age)
        {
            if (string.IsNullOrEmpty(clas)) throw new ArgumentNullException("empty field detected");
            if (string.IsNullOrEmpty(type)) throw new ArgumentNullException("empty field detected");
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("empty field detected");
            if (string.IsNullOrEmpty(age)) throw new ArgumentNullException("empty field detected");
            switch (clas) 
            {
                case "Mammal" : return new Mammal(type, name, age);
                case "Bird" : return new Bird(type, name, age);
                case "Amphibian" : return new Amphibian(type, name, age);
                default : 
                    UnknownAnimal anim = new(type, name, age);
                    anim.Class = clas;
                    return anim;
            }
        }
    }
}
