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
            List<string> items = new List<string>();
            items.Add("Yaounde I");
            items.Add("Yaounde II");
            items.Add("Yaounde III");
            items.Add("Yaounde IV");
            items.Add("Yaounde V");
            items.Add("Yaounde VI");
            items.Add("Yaounde VII");
            ViewData["tems"] = new SelectList(items);
            return View();
        }
        
    }
}