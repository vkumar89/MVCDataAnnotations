using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDataAnnotations.Models;
namespace MVCDataAnnotations.Controllers
{
    public class UserController : Controller
    {
       public ViewResult AddUser()
        {
            return View();
        }
        public ViewResult DisplayUser(User user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("AddUser", user);
            }

        }
    }
}