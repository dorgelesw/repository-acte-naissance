using P7GestAct.Models.DataClass;
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
            List<Centre> centres = repository.GetListCentre().ToList<Centre>();
            List<Arrondissement> arrondissements = repository.GetListArrondissement().ToList<Arrondissement>();
            ViewBag.centres = centres;
            if (centres == null || centres.Count == 0)
            {
                return null;

            }
            ViewBag.arrondissements = arrondissements;
            if (arrondissements == null || arrondissements.Count==0 )
            {
                return null;
            }
            return View();
        }
        
    }
}