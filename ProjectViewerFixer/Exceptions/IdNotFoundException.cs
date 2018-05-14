using System;

namespace ProjectViewerFixer.Exceptions
{
    public class IdNotFoundException : Exception
    {

        private string _fileName;

        public string FileName {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value.ToLower().Replace(".jpg.json","");
            }
        }
        public int IdCounter { get; private set; }

        public override string Message
        {
            get
            {
                return string.Format("Не был найден один из ID category/size/package/brand в сопоставленном словаре.\nИмя файла: {0}\nObjectIdCounter: {1}", FileName, IdCounter);
            }
        }

        public IdNotFoundException(string dataFileName, int idCounter)
        {
            FileName = dataFileName;
            IdCounter = idCounter;
        }
    }
}
