using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EAD_Project.Models;
using Entities;
using DAL;

namespace EAD_Project.Controllers
{
    public class AdminController : Controller
    {
        Admin_Model model;   
        // GET: Admin
        public ActionResult Home()
        {
            if(Session["User_Id"]!=null)
            {
                model = new Admin_Model();
                return View(model);
            }
            return RedirectToAction("Login","Account");
        }
        public ActionResult Tables()
        {
            if (Session["User_Id"] != null)
            {
                List<ItemDTO> model1 = ItemDAO.getAllItems();
                return View(model1);
            }
            return RedirectToAction("Login", "Account");
        }
        public ActionResult DeleteItem(int data)
        {
            ItemDAO.DeleteItem(Convert.ToInt32(data));
            return RedirectToAction("Tables");
        }
        public ActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddItemInDB()
        {
            var uniq = "";
            string name = Request["Name"];
            string des = Request["Des"];
            string detai = Request["Detail"];
            int pold = Convert.ToInt32(Request["pold"]);
            int pnew = Convert.ToInt32(Request["pnew"]);
            int q = Convert.ToInt32(Request["quan"]);
            int rat = Convert.ToInt32(Request["rat"]);
            var fileName = "";
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];

                if (file != null && file.ContentLength > 0)
                {
                    fileName = System.IO.Path.GetFileName(file.FileName);
                    var path = System.IO.Path.Combine(Server.MapPath("~/Content/images/"), fileName);
                    file.SaveAs(path);
                }
            }
            string t1 = Request["type"].ToString();
            t1 = t1 +"_"+ Request["type1"].ToString();
            ItemDTO i = new ItemDTO(0, "", name, des, detai, fileName.ToString(), "", "", pold, pnew, q, rat);
            i.type = t1;
            ItemDAO.addOneItem(i);
            List<ItemDTO> model1 = ItemDAO.getAllItems();
            return View("Tables",model1);
        }
        public ActionResult EditItem(int data)
        {
            ItemDTO i=ItemDAO.getItemById(data);
            return View(i);
        }
        [HttpPost]
        public ActionResult EditItem()
        {
            string name = Request["Name"];
            string des = Request["Des"];
            string detai = Request["Detail"];
            int pold = Convert.ToInt32(Request["pold"]);
            int pnew = Convert.ToInt32(Request["pnew"]);
            int q = Convert.ToInt32(Request["quan"]);
            int rat = Convert.ToInt32(Request["rat"]);
            int Id = Convert.ToInt32(Request["Id"]);
            var fileName = "";
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];

                if (file != null && file.ContentLength > 0)
                {
                    fileName = System.IO.Path.GetFileName(file.FileName);
                    var path = System.IO.Path.Combine(Server.MapPath("~/Content/images/"), fileName);
                    file.SaveAs(path);
                }
            }
            ItemDTO i = new ItemDTO(Id, "", name, des, detai, fileName.ToString(), "", "", pold, pnew, q, rat);
            ItemDAO.updateItem(i);
            List<ItemDTO> model1 = ItemDAO.getAllItems();
            return View("Tables", model1);
        }
        
    }
}