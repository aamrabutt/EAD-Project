using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string key { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public string picture1 { get; set; }
        public string picture2 { get; set; }
        public int priceOld { get; set; }
        public int priceNew { get; set; }
        public int quantity { get; set; }
        public int rating { get; set; }
        public string picture3 { get; set; }
        public string  explainedDescription { get; set; }

        public ItemModel(int i,string k, string n, string d,string ex, string pic1, string pic2,string pic3, int pold, int pnew, int qua, int ra)
        {
            this.Id = i;
            this.key = k;
            this.Name = n;
            this.explainedDescription = ex;
            this.description = d;
            this.picture3 = pic3;
            this.picture1 = pic1;
            this.picture2 = pic2;
            this.priceOld = pold;
            this.priceNew = pnew;
            this.quantity = qua;
            this.rating = ra;
        }
    }
}