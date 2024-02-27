using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPracticing
{
    internal class SaverManager
    {
        private IDataSaver _saver;
        public string Pages { get; set; }
        public SaverManager() => _saver = new JsonSaver("jsonFile");

        public void Save() => _saver.SaveToFile(Pages);

        public void SetMode(string mode)
        {
            switch(mode)
            {
                case "pdf": _saver = new PdfSaver("pdfFile"); break;
                case "txt": _saver = new TxtSaver("txtFile"); break;
                default: break;
            }
        }

        public List<IAnimal> Load()
        {
            return new();
        }
    }
}
