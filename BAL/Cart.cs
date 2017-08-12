using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Cart
    {
        public static void AddToCart(int id,int prodId,int price)
        {
            ItemDAO.AddToCart(id, prodId,price);
        }
        public static List<CartModel> getCart(int id)
        {
            List<CartModel> it = new List<CartModel>();
            List<Entities.Cart> prodId=ItemDAO.getCart(id);
            foreach(var i in prodId)
            {
                it.Add(new CartModel(ItemDAO.getItemById(i.productID), i.CartID));
            }
            return it;
        }
        public static int getBill(int id)
        {
            return DAL.ItemDAO.getBill(id);
        }
        public static int deleteFromCart(int id)
        {
            return DAL.ItemDAO.deleteCartById(id);
        }
    }
}
