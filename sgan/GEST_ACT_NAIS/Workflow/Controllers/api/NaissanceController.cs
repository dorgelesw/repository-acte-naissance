using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using P7GestAct.Models.DataClass;
using P7GestAct.Models.Repositories;

namespace P7GestAct.Controllers.api
{
    public class NaissanceController : ApiController
    {
        private IRepository repository = new SystemActeRepository();
        public int PostDeclaration(Naissance naiss)
        {
            return repository.addNaissance(naiss);
        }
    }
}
