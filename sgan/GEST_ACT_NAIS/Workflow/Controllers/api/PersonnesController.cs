using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using P7GestAct.Models.Repositories;
using P7GestAct.Models.DataClass;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace P7GestAct.Controllers.api
{
    public class PersonnesController : ApiController
    {
        
            IRepository repository = new SystemActeRepository();
        

        public IEnumerable<Personne> GetPersonnes()
        {
            
            return repository.Personnes;
        }
        public IHttpActionResult GetPersonne(int id)
        {
            Personne result = repository.Personnes.Where(p => p.PersonneID==id).FirstOrDefault();
            return result == null ? (IHttpActionResult)BadRequest("aucun declarant") : Ok(result);
        }
        public int PostPersonne(Personne personne)
        {
            if (ModelState.IsValid)
            {
                return repository.addPersonne(personne);
            }
            else
            {
                return 0;
            }
        }
        }
    }

