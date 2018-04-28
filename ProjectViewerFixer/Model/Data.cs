using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectViewerFixer.Model
{
    class Data
    {
        public string hash { get; set; }
        public int shelf_number { get; set; }
        public Shelf[] shelfs { get; set; }
        public Object[] objects { get; set; }
    }
}
