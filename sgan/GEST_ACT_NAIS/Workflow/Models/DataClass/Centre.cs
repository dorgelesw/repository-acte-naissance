using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Centre
    {
        public Int64 CentreID { get; set; }
        public String C_Name { get; set; }
        public String C_Lieux { get; set; }

        public Int64 CommuneID { get; set; }
        public virtual Commune Commune { get; set; }
        public virtual ICollection<Declaration> Declarations { get; set; }
    }
}
