using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Commune
    {
        public int CommuneID { get; set; }

        [Required]
        public String Commune_Name { get; set; }

        public int ArrondissementID { get; set; }
        public Arrondissement Arrondissement { get; set; }
    }
}
