using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace P7GestAct.Models.DataClass
{
    public class Personne
    {

        public Int64 PersonneID { get; set; }

        [Required(ErrorMessage = "Please enter the complete name")]
        [DisplayName("Nom complet")]
        public String P_Name { get; set; }

        [Required]
        //[DataType(DataType.Date)]
        [DisplayName("Date de naissance")]
        //[DisplayFormat(DataFormatString="{dd/MM/yy}")]
        public string P_Date_Naissance { get; set; }

        [Required]
        [DisplayName("Lieu de naissance")]
        public String P_Lieu_Naissance { get; set; }

        [Required]
        [DisplayName("Sexe")]
        public String P_Sexe { get; set; }
        public Int64 ArrondissementID { get; set; }
        public virtual Arrondissement Arrondissement { get; set; }
        public virtual ICollection<Domicile> Domiciles { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<EtatCivil> Etat_Civils { get; set; }
        public virtual ICollection<Declaration> Declarations { get; set; }
         
    }
}