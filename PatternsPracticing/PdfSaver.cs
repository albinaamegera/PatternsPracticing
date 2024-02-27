using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatternsPracticing
{
    internal class PdfSaver : DataSaver, IDataSaver
    {
        public PdfSaver(string filename) : base(filename) { }

        public void SaveToFile(string pages)
        {
            MessageBox.Show($"page saved to {_fileName}.pdf");
        }
    }
}
