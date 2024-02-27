using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPracticing
{
    internal class Amphibian : IAnimal
    {
        public string Class { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public Amphibian(string type, string name, string age)
        {
            Class = "Amphibian";
            Type = type;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Class}\n{Type}\n{Name}\n{Age}";
        }
        public void Edit(string clas, string type, string name, string age)
        {
            if (string.IsNullOrEmpty(type)) throw new ArgumentNullException("empty field detected");
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("empty field detected");
            if (string.IsNullOrEmpty(age)) throw new ArgumentNullException("empty field detected");
            Type = type;
            Name = name;
            Age = age;
        }
    }
}
