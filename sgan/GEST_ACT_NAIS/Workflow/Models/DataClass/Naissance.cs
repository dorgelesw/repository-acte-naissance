using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace P7GestAct.Models.DataClass
{
    public class Naissance
    {
        public int NaissanceID { get; set; }

        [Required]
        [DisplayName("Nom de l'enfant")]
        public String N_Name {get; set;}

        [Required]
        [DisplayName("Prenom de l'enfant")]
        public String N_Prenom { get; set; }

        [Required]
        //[DataType(DataType.DateTime)]
        [DisplayName("Date de naissance de l'enfant")]
        //[DisplayFormat(DataFormatString="{dd/MM/yy}")]
        public string N_Date_Heure { get; set; }

        [Required]
        [DisplayName("Lieu naissance enfant")]
        public String N_Lieux { get; set; }

        [Required]
        [DisplayName("Légitime/adoptif")]
        public String N_Filiation { get; set; }

        [Required]
        [DisplayName("Sexe")]
        public Char N_Sexe { get; set; }

        public int DeclarationID { get; set; }
        public virtual Declaration Declaration { get; set; }

        public int PereID { get; set; }
        public virtual Pere Pere { get; set;}

        public int MereID { get; set; }
        public virtual Mere Mere { get; set; }
    }
}