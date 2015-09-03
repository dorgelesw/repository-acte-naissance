using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class EtatCivil
    {
        public int EtatCivilID { get; set; }

        [Required]
        public String Nationalite { get; set; }

        [Required]
        public String Status_Matrinomiale { get; set; }

        [Required]
        public String Profession { get; set; }

        [DisplayName("upload National Identity Card")]
        public byte[] CNI { get; set; }

        [DisplayName("upload marriage certificate")]
        public byte[] ActeMariage { get; set; }

        [DisplayName("upload parental certificate")]
        public byte[] ActeReconnaissanceParentale { get; set; }

        public int PersonneID { get; set; }
        public virtual Personne Personne { get; set; }
    }
}
