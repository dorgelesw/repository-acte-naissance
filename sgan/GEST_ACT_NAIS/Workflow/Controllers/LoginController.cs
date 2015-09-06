using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P7GestAct.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
    [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User users)
        {
            // this action is for handle post (login)
            if (ModelState.IsValid) // this is check validity
            {
                using (sganEntities dc = new sganEntities())
                {
                    var v = dc.User.Where(a => a.Username.Equals(users.Username) && a.Password.Equals(users.Password)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["LogedUserID"] = v.UserId.ToString();
                        Session["LogedUserFullname"] = v.FullName.ToString();
                        return RedirectToAction("Index");
                    }
                }
            }
            return View(users);

        }
    public ActionResult AfterLogin()
    {
        if (Session["LogedUserID"] != null)
        {
            return View();
        }
        else
        {
            return RedirectToAction("~/Views/Accueil/Index");
        }
    }
    }
}