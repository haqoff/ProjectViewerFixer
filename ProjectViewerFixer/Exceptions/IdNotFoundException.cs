using System;

namespace ProjectViewerFixer.Exceptions
{
    public class IdNotFoundException : Exception
    {

        private string _fileName;
        private string id;
        private IdType type;
              
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

        public IdNotFoundException(string id, string dataFileName, int idCounter, IdType type)
        {
            FileName = dataFileName;
            IdCounter = idCounter;
            this.id = id;
            this.type = type;
        }

        public override string Message => string.Format("Не найден {0}Id: {1} в сопоставленном словаре {0}.", type.ToString(), id);

        public enum IdType
        {
            Category,
            Size,
            Brand,
            Package
        }
    }
}
