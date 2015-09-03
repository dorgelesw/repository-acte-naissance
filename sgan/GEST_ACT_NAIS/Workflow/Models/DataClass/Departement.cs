using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Departement
    {
        public int DepartementID { get; set; }

        [Required]
        public String Dept_Name { get; set; }

        public String Dept_Chef_Lieu { get; set; }


        public int RegionID { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Arrondissement> Arrondissements { get; set; }
    }
}
