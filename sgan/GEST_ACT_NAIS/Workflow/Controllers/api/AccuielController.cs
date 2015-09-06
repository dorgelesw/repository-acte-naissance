using P7GestAct.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P7GestAct.Controllers.api
{
    public class AccuielController : Controller
    {
        IRepository repository;

        public AccuielController()
        {
            repository = new SystemActeRepository();
        }

        // GET: Accuiel
        public ActionResult Index()
        {
            return View();
        }
        
    }
}