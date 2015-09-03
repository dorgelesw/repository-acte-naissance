using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace P7GestAct.Models.DataClass
{
    public class Region
    {
        public int RegionID { get; set; }

        [Required]
        public String Region_Name { get; set; }
        public String Region_Chef_Lieu { get; set; }

        public int PaysID { get; set; }
        public virtual Pays Pays { get; set; }
        public virtual ICollection<Departement> Departements { get; set; }
    }
}