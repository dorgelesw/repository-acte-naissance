using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Mere : Personne
    {
        [Required]
        [DisplayName("Nom de famille à la naissance")]
        public String M_Nom_Famille_Naissance { get; set; }

        public virtual ICollection<Naissance> Naissances { get; set; }
    }
}
