using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPracticing
{
    internal interface IView
    {
        public string ClassValue { get; set; }
        public string TypeValue { get; set; }
        public string NameValue { get; set; }
        public string AgeValue { get; set; }
        public string SaveMode { get; set; }
        public IAnimal Current { get; set; }
        public void ClearView();
    }
}
