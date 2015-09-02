using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Domicile
    {
        public Int64 DomicileID { get; set; }

        [Required]
        public String Pays { get; set; }

        [Required]
        public String Ville { get; set; }

        [Required]
        public String Proprietaire { get; set; }

        public Int64 PersonneID { get; set; }
        public virtual Personne Personne { get; set; }

    }
}
