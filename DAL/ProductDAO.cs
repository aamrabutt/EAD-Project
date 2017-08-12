using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductDAO
    {
        public static List<ItemDTO> getData(string val)
        {
            List<ItemDTO> li = new List<ItemDTO>();
            SqlDataReader res = DBHelper.ReaderQuery("select * from Shopify_Item where Item_Type = '"+val+"'");
            if (res != null)
            {
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
                    li.Add(item);
                }
            }

            return li;
        }
        public static List<ItemDTO> getData(int a1,int a2)
        {
            List<ItemDTO> li = new List<ItemDTO>();
            SqlDataReader res = DBHelper.ReaderQuery("select * from Shopify_Item where Item_Id BETWEEN "+a1+" AND "+a2);
            if(res!=null)
            {
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
                    li.Add(item);
                }
            }
           
            return li;
        }
    }
}
