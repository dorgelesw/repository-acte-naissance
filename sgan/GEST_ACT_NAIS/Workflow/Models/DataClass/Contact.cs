using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace P7GestAct.Models.DataClass
{
    public class Contact
    {
        public int ContactID { get; set; }

        [Required(ErrorMessage = "Please enter the Telephone number")]
        public String Tel { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        public String BP { get; set; }

        public int PersonneID { get; set; }
        public virtual Personne Personne { get; set; }
    }
}
