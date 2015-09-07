using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using P7GestAct.Models.DataClass;
using P7GestAct.Models.Repositories;
using System.Threading.Tasks;

namespace P7GestAct.Controllers.api
{   
   
    public class DeclarationController : ApiController
    {
        private IRepository repository = new SystemActeRepository();
        //Post/api/declaration
      
        public int  PostDeclaration(Declaration del)
        {
            del.CentreID = 1;
            if (ModelState.IsValid)
            {
                return repository.addDeclaration(del);
            }
            else
            {
                return 1234;
            }
            
        }
    }
}
