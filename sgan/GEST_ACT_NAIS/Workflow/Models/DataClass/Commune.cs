using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Commune
    {
        public Int64 CommuneID { get; set; }

        [Required]
        public String Commune_Name { get; set; }

        public Int64 ArrID { get; set; }
        public Arrondissement Arrondissement { get; set; }
    }
}
