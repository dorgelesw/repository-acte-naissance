using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P7GestAct.Controllers
{
    public class PrintController :Controller
    {
        // GET: PdfView
        public ActionResult pdfvue()
        {
            return View();
        }
    }
}