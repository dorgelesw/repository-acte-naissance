using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Arrondissement
    {
        public int ArrondissementID { get; set; }

        [Required]
        public String Arrondissement_Name { get; set; }

        public int DepartementID { get; set; }
        public virtual Departement Departement { get; set; }
        public virtual ICollection<Commune> Communes { get; set; }
        public virtual ICollection<Personne> Personnes { get; set; }
    }
}
