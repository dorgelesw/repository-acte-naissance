using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Domicile
    {
        public int DomicileID { get; set; }

        [Required]
        public String Pays { get; set; }

        [Required]
        public String Ville { get; set; }

        [Required]
        public String Proprietaire { get; set; }

        public int PersonneID { get; set; }
        public virtual Personne Personne { get; set; }

    }
}
