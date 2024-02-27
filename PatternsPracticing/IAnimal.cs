using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPracticing
{
    public interface IAnimal
    {
        public string Class { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public void Edit(string clas, string type, string name, string age);
    }
}
