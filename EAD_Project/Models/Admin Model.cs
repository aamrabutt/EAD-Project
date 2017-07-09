using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace EAD_Project.Models
{
    public class Admin_Model
    {
        public Admin_Model()
        {
            totalUsers = 500;
            totalcomments = 100;
            totalOrders = 200;
            totalViews = 100;

            name = "abc";
            //pictureURL = "~/Content/images/admin.png";
            noOfOrders = 40;
            Comments = 20;
            newUsers = 10;
            Views = 5;
            tables = null;
            messages = new Message();
            messages.AdminMessage = "hello admin how are you";
            messages.sendername = "Aamra";
        }
        public string name { get; set; }
        //public string pictureURL { get; set; }
        public int noOfOrders { get; set; }
        public int Comments { get; set; }
        public int newUsers { get; set; }
        public int Views { get; set; }
        public DataSet tables { get; set; }
        public Message messages { get; set; }
        public int totalUsers { get; set; }
        public int totalViews { get; set; }
        public int totalOrders { get; set; }
        public int totalcomments { get; set; }
    }
    public class Message
    {
        public String sendername { get; set; }
        public string AdminMessage { get; set; }
    }
}
