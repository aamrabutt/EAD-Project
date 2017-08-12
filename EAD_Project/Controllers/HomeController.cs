using BAL;
using EAD_Project.Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace EAD_Project.Controllers
{
    public class HomeController : Controller
    {
        //public void get()
        //{
        //    var ShopifyEntities  b= new ShopifyEntities();
        //    UserDTO u = new UserDTO();
            
        //}
        [HttpPost]
        public JsonResult func1(List<String> val)
        {
            int id = Convert.ToInt32(val[1]);
            object data = null;
            data = new
            {
                valid = 0
            };

            JsonResult jsonResult = new JsonResult()
            {
                Data = data,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

            return jsonResult;

        }
        public ActionResult Bill(int data)
        {
            if(Session["User_Id"]==null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                BAL.Cart.AddToCart(Convert.ToInt32(Session["User_Id"].ToString()), data, IndexModel.get(data, IndexModel.getAllData()).priceNew);
            }
            return RedirectToAction("IndexM","Home");
        }
        public ActionResult Product(string data)
        {
            string[] tokens = data.Split('_');
            return View(ProductBO.getProduct(tokens[0], tokens[1]));
        }
        public ActionResult IndexM()
        {

            //IndexModel.getAllData1();
            IndexModel i = new IndexModel();
            i.myList = BAL.ItemBO.getAll();
            return View(i);
        }
        public ActionResult UpdateProfile(int id)
        {
            if (Session["User_Id"] != null)
            {
                UserDTO u = BAL.UserBO.getById(id);
                return View(u);
            }
            ViewBag.error = "Please login to continue";
            return RedirectToAction("Error", "Account");
        }
        public ActionResult UpdateMe(string tab_fname, string tab_lname, string tab_email, string tab_phone, string tab_pass, string tab_address, string tab_country)
        {
            if (Session["User_Id"] != null)
            {
                UserDTO user = new UserDTO();
                user.fName = tab_fname;
                user.lName = tab_lname;
                user.email = tab_email;
                user.phone = tab_phone;
                user.password = tab_pass;
                user.address = tab_address;
                user.country = tab_country;
                user.pic = "2.png";
                BAL.UserBO.update(user);
                return View("UpdateProfile", user.Id);
            }
            ViewBag.error = "Please login to continue";
            return RedirectToAction("Error", "Account");
        }
        public ActionResult Index()
        {
            return RedirectToAction("IndexM");
        }
        public ActionResult profile(int id)
        {
            if(Session["User_Id"]!=null)
                return View(BAL.UserBO.getById(id));
            else
                return RedirectToAction("Login", "Account");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Single(int id)
        {
            if (Session["User_Id"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(IndexModel.get(id, IndexModel.getAllData()));
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult ContactMe()
        {
            string name = Request["txt_name"];
            string senderEmail = Request["txt_email"];
            string sub = Request["txt_sub"];
            string msg = Request["txt_msg"];
            sendemail(senderEmail, name, sub, msg);
            return View("Index");
        }
        public ActionResult DeleteFromCart(int data)
        {
            BAL.Cart.deleteFromCart(data);
            return RedirectToAction("CheckOut", "Home");
        }
        public ActionResult CheckOut()
        {
            if (Session["User_Id"] != null)
            {
                List<CartModel> model = new List<CartModel>();
                model = BAL.Cart.getCart(Convert.ToInt32(Session["User_Id"].ToString()));
                return View(model);
            }
            else
                return RedirectToAction("Login", "Account");
        }
        private static bool sendemail( string from,string name,string sub,string msg)
        {
            bool flag = false;
            try
            {
                string to = System.Configuration.ConfigurationManager.AppSettings["UserName"];
                String pass = System.Configuration.ConfigurationManager.AppSettings["password"];

                MailAddress From = new MailAddress(to, name);
                MailAddress To = new MailAddress(to);
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(From.Address, pass)
                };

                using (var message = new MailMessage(From, To)
                {
                    Subject = sub,
                    Body = msg,

                })
                {
                    smtp.Send(message);
                }
                flag = true;
            }
            catch (Exception)
            {
                //Console.WriteLine("Mail not sent : "+ex.ToString());
            }
            return flag;
        }
    }
}