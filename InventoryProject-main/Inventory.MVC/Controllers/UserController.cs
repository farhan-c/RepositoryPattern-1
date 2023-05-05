using Inventory.Database.DataContextClass;
using Inventory.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers
{
    public class UserController : Controller
    {
        InventoryDBcontext db = new InventoryDBcontext();

        public ActionResult GetAllUsers()
        {
            var users = db.Users.ToList();
            return View(users);
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("GetAllUsers");
            }
            return View();
        }
    }
}