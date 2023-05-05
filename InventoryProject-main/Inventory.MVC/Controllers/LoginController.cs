using Inventory.Database.DataContextClass;
using Inventory.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers
{
    public class LoginController : Controller
    {
        InventoryDBcontext db = new InventoryDBcontext();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var isValid = db.Users.Any(x => x.UserName == user.UserName && x.Password == user.Password);
            if (isValid)
            {
                return RedirectToAction("CategoryList", "Category");
            }
            ViewBag.IsNotvalid = "Please ENter Correct user name and Password";
            return View();
        }

    }
}