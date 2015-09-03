using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Pays
    {
        public int PaysID { get; set; }

        [Required]
        public String Pays_Name { get; set; }
        public String Pays_Small_Name { get; set; }

        public virtual ICollection<Langue> Langues { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
