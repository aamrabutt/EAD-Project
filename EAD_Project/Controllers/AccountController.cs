using System;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
using Entities;
namespace EAD_Project.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private static Random random = new Random();

        
        
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult RegisterMe()
        {
            //Shopify_EntityFramework.Shopify_Users u = new Shopify_EntityFramework.Shopify_Users();
            
            UserDTO u=new UserDTO();
            u.fName = Request["txt_firstName"];
            u.lName = Request["txt_lastName"];
            u.phone = Request["txt_phone"];
            u.password = Request["txt_pass"];
            u.address = Request["txt_address"];
            u.gender = Request["gender"];
            u.country = Request["txt_country"];
            u.email = Request["txt_email"];
            
            int res=BAL.UserBO.insert(u);
            Session["User_Id"] =res;
            //Make session here 
            return RedirectToAction("Index", "Home");
        }
        [AllowAnonymous]
        public ActionResult LogOut(int id)
        {
            Session["User_Id"] = null;
            Session["User_Name"] = null;
            Session["pic"] = null;
            Session["phone"] = null;
            return View("Login");

        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult LoginMe()
        {
            string email= Request["txt_email"];
            string pass= Request["txt_pass"];
            UserDTO u = BAL.UserBO.getByEmail(email);
            if (u != null)
            {
                if (u.password.Equals(pass))
                {
                    Session["User_Id"] = u.Id;
                    Session["User_Name"] = u.fName;
                    Session["pic"] = u.pic;
                    Session["phone"] = u.phone;
                    return RedirectToAction("Index", "Home");
                }   
                else
                {
                    ViewBag.Error = "Invalid Password";
                    // return JavaScript("<script>alert(\"Password is not correct\")</script>");
                    return View("Login");
                }

            }
            else
            {
                ViewBag.Error = "Account does not Exist";
                return View("Login");
            }
        }
        [AllowAnonymous]
        public ActionResult Error()
        {
            return View();
        }
        /*
        [AllowAnonymous]
        public bool ForgotPassword(string email)
        {
            Shopify_EntityFramework.Shopify_Users u= DAL.DataAccess.getOne(email);
            if(u!=null)
            {

                int length = 10;
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                string result = new string(
                        Enumerable.Repeat(chars, length)
                                  .Select(s => s[random.Next(s.Length)])
                                  .ToArray());
                bool status = sendemail("You have asked for password reset click this link to reset your password \n http://localhost:49493/Person/ForgotPassword1?email=" + email + "&Code=" + result, email);
            }
            
            return true;
        }*/
        private static bool sendemail(String message1, string to)
        {
            bool flag = false;
            try
            {
                string from = System.Configuration.ConfigurationManager.AppSettings["UserName"];
                String pass = System.Configuration.ConfigurationManager.AppSettings["password"];
                String name = "Shopify";

                MailAddress From = new MailAddress(from, name);
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
                    Subject = "Shopify_Password_Reset",
                    Body = message1,

                })
                {
                    smtp.Send(message);
                }
                flag = true;
            }
            catch (Exception )
            {
                //Console.WriteLine("Mail not sent : "+ex.ToString());
            }
            return flag;
        }
    }
}