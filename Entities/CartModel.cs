using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CartModel
    {
        public ItemDTO item { get; set; }
        public  int id { get; set; }
        public CartModel()
        {
            item = new ItemDTO();
        }
        public CartModel(ItemDTO i,int id):this()
        {
            item = i;
            this.id = id;
        }
    }
}
