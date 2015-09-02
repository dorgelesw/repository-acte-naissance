using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Departement
    {
        public Int64 DepartementID { get; set; }

        [Required]
        public String Dept_Name { get; set; }

        public String Dept_Chef_Lieu { get; set; }


        public Int64 RegionID { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Arrondissement> Arrondissements { get; set; }
    }
}
