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
   
    public class MereController : ApiController
    {
        private IRepository repository = new SystemActeRepository();
        public int PostMere(Mere meres){
            
            if (ModelState.IsValid)
            {
                return repository.addMere(meres);
            }
            else
            {
                return 123;
            }
        }
    }
}
