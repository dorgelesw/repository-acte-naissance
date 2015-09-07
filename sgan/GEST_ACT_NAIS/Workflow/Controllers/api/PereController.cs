using P7GestAct.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using P7GestAct.Models.DataClass;


namespace P7GestAct.Controllers.api
{
    public class PereController : ApiController
    {
        private IRepository repository = new SystemActeRepository();
        public int PostPere(Pere peres)
        {
            peres.P_Sexe = "Homme";
            peres.ArrondissementID = 1;
            if (ModelState.IsValid)
            {
                return repository.addPere(peres);
            }
            else
            {
                return 12;

            }
        }
    }
}
