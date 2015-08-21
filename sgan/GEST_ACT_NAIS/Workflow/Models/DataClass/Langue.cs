using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Langue
    {
        public Int64 LangueID { get; set; }
        public String Langue_Name { get; set; }
        public String Langue_Small_Name { get; set; }

        public Int64 PaysID { get; set; }
        public virtual Pays Pays { get; set; }
    }
}
