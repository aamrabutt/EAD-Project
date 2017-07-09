using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EAD_Project.Models;
namespace EAD_Project.Controllers
{
    public class AdminController : Controller
    {
        Admin_Model model;   
        // GET: Admin
        public ActionResult Home()
        {
            model = new Admin_Model();
            return View(model);
        }
        public ActionResult Tables()
        {
            model = new Admin_Model();
            return View(model);
        }
        public ActionResult Messages()
        {
            model = new Admin_Model();
            return View(model);
        }
    }
}