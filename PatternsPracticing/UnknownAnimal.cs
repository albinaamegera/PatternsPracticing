using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPracticing
{
    internal class UnknownAnimal : IAnimal
    {
        public string Class { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public UnknownAnimal(string type, string name, string age)
        {
            Class = "unknown";
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
            if (string.IsNullOrEmpty(clas)) throw new ArgumentNullException("empty field detected");
            if (string.IsNullOrEmpty(type)) throw new ArgumentNullException("empty field detected");
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("empty field detected");
            if (string.IsNullOrEmpty(age)) throw new ArgumentNullException("empty field detected");
            Class = clas;
            Type = type;
            Name = name;
            Age = age;
        }
    }
}
