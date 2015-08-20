using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Pere : Personne
    {
        [Required]
        [DisplayName("Nom de famille")]
        public String P_Nom_Famille { get; set; }

        public virtual ICollection<Naissance> Naissances { get; set; }
    }
}
