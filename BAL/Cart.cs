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
        public static List<ItemDTO> getCart(int id)
        {
            List<ItemDTO> it = new List<ItemDTO>();
            List<int> prodId=ItemDAO.getCart(id);
            foreach(var i in prodId)
            {
                it.Add(ItemDAO.getItemById(i));
            }
            return it;
        }
        public static int getBill(int id)
        {
            return DAL.ItemDAO.getBill(id);
        }
    }
}
