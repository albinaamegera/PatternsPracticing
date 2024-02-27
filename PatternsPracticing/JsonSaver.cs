using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatternsPracticing
{
    internal class JsonSaver : DataSaver, IDataSaver
    {
        public JsonSaver(string filename) : base(filename) { }

        public void SaveToFile(string Pages)
        {
            MessageBox.Show($"pages saved to {_fileName}.json");
        }
    }
}
