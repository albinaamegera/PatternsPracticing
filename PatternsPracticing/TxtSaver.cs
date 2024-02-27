using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatternsPracticing
{
    internal class TxtSaver : DataSaver, IDataSaver
    {
        public TxtSaver(string filename) : base(filename) { }

        public void SaveToFile(string pages)
        {
            MessageBox.Show($"pages saved to {_fileName}.txt");
        }
    }
}
