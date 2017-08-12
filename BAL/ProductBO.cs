using DAL;
using Entities;
using System.Collections.Generic;

namespace BAL
{
    public class ProductBO
    {
        public static List<ItemDTO> getProduct(string productOf,string productType)
        {
            if (productOf.Equals("Men"))
            {
                return getMenData(productType);
            }
            else if (productOf.Equals("Women"))
            {
                return getWomenData(productType);
            }
            else if (productOf.Equals("Kids"))
            {
                return getKidsData(productType);
            }
                return null;
        }
        private static List<ItemDTO> getMenData(string productType)
        {
            List<ItemDTO> li = new List<ItemDTO>();
            if(productType.Equals("Cloth"))
            {
                //li = ProductDAO.getData(8,13);
                li = ProductDAO.getData("Men_Cloth");
                return li;
            }
            else if(productType.Equals("Wallet"))
            {
                //li = ProductDAO.getData(15, 17);
                li = ProductDAO.getData("Men_Wallet");
                return li;    
            }
            else if(productType.Equals("Shoes"))
            {
                //li = ProductDAO.getData(18, 20);
                li = ProductDAO.getData("Men_Shoes");
                return li;
            }
            else if(productType.Equals("Watches"))
            {
                //li = ProductDAO.getData(45, 47);
                li = ProductDAO.getData("Men_Watch");
                return li;
            }
            return null;
        }
        private static List<ItemDTO> getWomenData(string productType)
        {
            List<ItemDTO> li = new List<ItemDTO>();
            if (productType.Equals("Cloth"))
            {
                //li = ProductDAO.getData(21, 23);
                li = ProductDAO.getData("Women_Cloth");
                return li;
            }
            else if (productType.Equals("Wallet"))
            {
                //li = ProductDAO.getData(24, 26);
                li = ProductDAO.getData("Women_Wallet");
                return li;
            }
            else if (productType.Equals("Shoes"))
            {
                //li = ProductDAO.getData(27, 29);
                li = ProductDAO.getData("Women_Shoes");
                return li;
            }
            else if (productType.Equals("Watches"))
            {
                //li = ProductDAO.getData(30, 32);
                li = ProductDAO.getData("Women_Watches");
                return li;
            }
            return null;
        
        }
        private static List<ItemDTO> getKidsData(string productType)
        {
            List<ItemDTO> li = new List<ItemDTO>();
            if(productType.Equals("BoyCloth"))
            {
                //li = ProductDAO.getData(33, 35);
                li = ProductDAO.getData("BoyCloth");
                return li;
            }
            else if(productType.Equals("GirlCloth"))
            {
                //li = ProductDAO.getData(36,38);
                li = ProductDAO.getData("GirlCloth");
                return li;
            }
            else if(productType.Equals("Shoes"))
            {
                //li = ProductDAO.getData(39,44);
                li = ProductDAO.getData("Kids_Shoes");
                return li;
            }
            return null;
        }
    }
}
