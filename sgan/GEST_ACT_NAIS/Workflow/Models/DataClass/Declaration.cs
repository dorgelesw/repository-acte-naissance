using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace P7GestAct.Models.DataClass
{
    public class Declaration
    {
        public Int64 DeclarationID { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Date de declaration")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime D_Date_Heure { get; set; }

        [Required]
        public String D_Lieu { get; set; }

        public String D_Name { get; set; }

        public Int64 PersonneID { get; set; }
        public virtual Personne Personne { get; set; }

        public Int64 CentreID { get; set; }
        public virtual Centre Centre { get; set; }

        public virtual ICollection<Naissance> Naissances { get; set; }
    }
}