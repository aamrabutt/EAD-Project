using Entities;
using System.Collections.Generic;

namespace BAL
{
    public class ItemBO
    {
        public static int insertItem(List<ItemDTO> it)
        {
            return DAL.ItemDAO.addItem(it);
        }
        public static List<ItemDTO> getAll()
        {
            List<ItemDTO> list = new List<ItemDTO>();
            //list.Add(new ItemDTO(1, "Blue Shirt", "FORMAL SHIRT", "A formal shirt for your use.", "This is explained description", "7.jpg", "2.jpg", "4.jpg", 350, 250, 6, 4));
            list.Add(new ItemDTO(1, "Blue Shirt", "FORMAL SHIRT", "A formal shirt for your use.", "This is explained description", "7.jpg", "2.jpg", "4.jpg", 350, 250, 6, 4));
            list.Add(new ItemDTO(2, "running shoes", "RUNNING SHOES", "Beautiful shoes for you.", "This is explained description", "8.jpg", "3.jpg", "4.jpg", 300, 200, 4, 3));
            list.Add(new ItemDTO(3, "dining table", "DINING TABLE", "A perfect dining table.", "This is explained description", "5.jpg", "5.jpg", "4.jpg", 600, 560, 4, 5));
            list.Add(new ItemDTO(4, "lamp 1", "WALL LAMP", "A decentlamp.", "This is explained description", "6.jpg", "5.jpg", "4.jpg", 500, 420, 4, 4));
            list.Add(new ItemDTO(5, "lamp 2", "WALL LAMP", "A casual lamp.", "This is explained description", "9.jpg", "5.jpg", "4.jpg", 200, 150, 4, 3));
            list.Add(new ItemDTO(6, "necklace", "PEARL AND STONE ANCKLET", "A gorgeous ancklet.", "This is explained description", "10.jpg", "5.jpg", "4.jpg", 300, 280, 4, 4));
            list.Add(new ItemDTO(7, "bangles", "STONES BANGLES", "Stone bangles.", "This is explained description", "11.jpg", "5.jpg", "4.jpg", 200, 150, 4, 3));
            return list;
            //return DAL.ItemDAO.getAllItems();
        }
        public static ItemDTO getById(int id)
        {
            return DAL.ItemDAO.getItemById(id);
        }
    }
}
