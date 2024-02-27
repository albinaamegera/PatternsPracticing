namespace PatternsPracticing
{
    internal abstract class DataSaver
    {
        protected string _fileName;

        public DataSaver(string fileName) => _fileName = fileName;
    }
}
