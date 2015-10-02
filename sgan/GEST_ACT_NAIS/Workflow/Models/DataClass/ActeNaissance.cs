using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7GestAct.Models.DataClass
{
    public class ActeNaissance
    {
        public int Acte_NaissanceID { get; set; }
        [Required]
        public Naissance enfant { get; set; }
        public Declaration  declaration{get;set;}
        public Pere papa { get; set; }
        public Mere maman { get; set; }
        public Personne declarant { get; set; }
    }
}
