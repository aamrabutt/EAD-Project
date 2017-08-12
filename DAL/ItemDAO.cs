using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class ItemDAO
    {
        public static int addOneItem(ItemDTO it)
        {
            string query = "insert into Shopify_Item (Item_Key,Name,Description,Picture1,Picture2,Picture3,PriceOld,PriceNew,Quantity,Rating,Ex_Description,Item_Type) Values ('" + it.key + "','" + it.Name + "','" + it.description + "','" + it.picture1 + "','" + it.picture2 + "','" + it.picture3 + "'," + it.priceOld + "," + it.priceNew + "," + it.quantity + "," + it.rating + ",'" + it.explainedDescription + "','"+it.type+"')";
            return DBHelper.NonQuery(query);
        }
        public static int updateItem(ItemDTO it)
        {
            string query = "Update Shopify_Item set Name = '"+it.Name+"', Description = '"+it.description+"' , Picture1 = '"+it.picture1+"',PriceOld = "+it.priceOld+",PriceNew = "+it.priceNew+",Quantity = "+it.quantity+",Rating = "+it.rating+",Ex_Description = '"+it.explainedDescription+ "' where Item_Id = "+it.Id;
            return DBHelper.NonQuery(query);
        }
        public static int addItem(List<ItemDTO> item)
        {
            int res = -999;
            foreach (var it in item)
            {
                string query = "insert into Shopify_Item (Item_Key,Name,Description,Picture1,Picture2,Picture3,PriceOld,PriceNew,Quantity,Rating,Ex_Description) Values ('" + it.key + "','" + it.Name + "','" + it.description + "','" + it.picture1 + "','" + it.picture2 + "','" + it.picture3 + "'," + it.priceOld + "," + it.priceNew + "," + it.quantity + "," + it.rating + ",'" + it.explainedDescription + "')";
                res = DBHelper.NonQuery(query);
            }
            return res;
        }
        public static int DeleteItem(int id)
        {
            return DBHelper.NonQuery("delete from Shopify_Item where Item_Id = " + id);
        }
        public static List<ItemDTO> getAllItems()
        {
            List<ItemDTO> i = new List<ItemDTO>();
            string query = "Select * from Shopify_Item";
            SqlDataReader res = DAL.DBHelper.ReaderQuery(query);
            while (res.Read())
            {
                ItemDTO item = new ItemDTO();
                item.Id = Convert.ToInt32(res["Item_Id"].ToString());
                item.key = res["Item_Key"].ToString();
                item.Name = res["Name"].ToString();
                item.description = res["Description"].ToString();
                item.picture1 = res["Picture1"].ToString();
                item.picture2 = res["Picture2"].ToString();
                item.picture3 = res["Picture3"].ToString();
                item.priceNew = Convert.ToInt32(res["PriceNew"].ToString());
                item.priceOld= Convert.ToInt32(res["PriceOld"].ToString());
                item.quantity= Convert.ToInt32(res["Quantity"].ToString());
                item.rating = Convert.ToInt32(res["Rating"].ToString());
                item.explainedDescription = res["Ex_Description"].ToString();
                i.Add(item);
            }
            return i;
        }
        public static ItemDTO getItemById(int id)
        {
            ItemDTO item = new ItemDTO();
            string query = "Select * from Shopify_Item where Item_Id = '" + id + "'";
            SqlDataReader res = DAL.DBHelper.ReaderQuery(query);
            if (res.Read())
            {
                item.Id = Convert.ToInt32(res["Item_Id"].ToString());
                item.key = res["Item_Key"].ToString();
                item.Name = res["Name"].ToString();
                item.description = res["Description"].ToString();
                item.picture1 = res["Picture1"].ToString();
                item.picture2 = res["Picture2"].ToString();
                item.picture3 = res["Picture3"].ToString();
                item.priceNew = Convert.ToInt32(res["PriceNew"].ToString());
                item.priceOld = Convert.ToInt32(res["PriceOld"].ToString());
                item.quantity = Convert.ToInt32(res["Quantity"].ToString());
                item.rating = Convert.ToInt32(res["Rating"].ToString());
                item.explainedDescription = res["Ex_Description"].ToString();
                return item;
            }
            return null;
        }
        //public static CartModel getItemByCartId(int id)
        //{
        //    CartModel c = new CartModel();
        //    ItemDTO item = new ItemDTO();
        //    string query = "Select * from Shopify_Item where Item_Id = '" + id + "'";
        //    SqlDataReader res = DAL.DBHelper.ReaderQuery(query);
        //    if (res.Read())
        //    {
        //        item.Id = Convert.ToInt32(res["Item_Id"].ToString());
        //        item.key = res["Item_Key"].ToString();
        //        item.Name = res["Name"].ToString();
        //        item.description = res["Description"].ToString();
        //        item.picture1 = res["Picture1"].ToString();
        //        item.picture2 = res["Picture2"].ToString();
        //        item.picture3 = res["Picture3"].ToString();
        //        item.priceNew = Convert.ToInt32(res["PriceNew"].ToString());
        //        item.priceOld = Convert.ToInt32(res["PriceOld"].ToString());
        //        item.quantity = Convert.ToInt32(res["Quantity"].ToString());
        //        item.rating = Convert.ToInt32(res["Rating"].ToString());
        //        item.explainedDescription = res["Ex_Description"].ToString();
        //        c.item = item;
        //        c.id=
        //        return ;
        //    }
        //    return null;
        //}
        public static List<ItemDTO> getItemByKey(string key)
        {
            List<ItemDTO> i = new List<ItemDTO>();
            string query = "Select * from Shopify_Items where key = '"+key+"'";
            SqlDataReader res = DAL.DBHelper.ReaderQuery(query);
            while (res.Read())
            {
                ItemDTO item = new ItemDTO();
                item.Id = Convert.ToInt32(res["Item_Id"].ToString());
                item.key = res["Item_Key"].ToString();
                item.Name = res["Name"].ToString();
                item.description = res["Description"].ToString();
                item.picture1 = res["Picture1"].ToString();
                item.picture2 = res["Picture2"].ToString();
                item.picture3 = res["Picture3"].ToString();
                item.priceNew = Convert.ToInt32(res["PriceNew"].ToString());
                item.priceOld = Convert.ToInt32(res["PriceOld"].ToString());
                item.quantity = Convert.ToInt32(res["Quantity"].ToString());
                item.rating = Convert.ToInt32(res["Rating"].ToString());
                item.explainedDescription = res["Ex_Description"].ToString();
                i.Add(item);
            }
            return i;
        }
        public static int AddToCart(int id,int prodId,int price)
        {
            String query = "insert into Cart (User_Id,Prod_Id,Price) values (" + id + ","+prodId+","+price+")";
            return DAL.DBHelper.NonQuery(query);
        }
        public static List<Cart> getCart(int id)
        {
            List<Cart> prodId = new List<Cart>();
            string query = "select * from Cart where User_Id =" + id;
            SqlDataReader dr= DAL.DBHelper.ReaderQuery(query);
            while(dr.Read())
            {
                int a = Convert.ToInt32(dr["Prod_Id"].ToString().Trim());
                int b = Convert.ToInt32(dr["Id"].ToString().Trim());
                prodId.Add(new Cart(a,b));
            }
            return prodId;
        }
        public static int getBill(int id)
        {
            string query = "SELECT SUM(Price) from Cart where User_Id ="+id;
            return Convert.ToInt32(DAL.DBHelper.ScalarQuery(query));

        }
        public static int deletecart(int id)
        {
            string query = "Delete from cart where User_Id =" + id;
            return Convert.ToInt32(DAL.DBHelper.NonQuery(query));
        }
        public static int deleteCartById(int id)
        {
            string query = "Delete from cart where Id =" + id;
            return Convert.ToInt32(DAL.DBHelper.NonQuery(query));
        }
    }
}
