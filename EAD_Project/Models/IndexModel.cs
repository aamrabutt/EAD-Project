using BAL;
//using DAL;
using Entities;
using System.Collections.Generic;

namespace EAD_Project.Models
{
    public class IndexModel
    {
        public List<ItemDTO> myList { get; set; }
        
        public IndexModel()
        {
            myList = new List<ItemDTO>();
        }
        public IndexModel(List<ItemDTO> u)
        {
           this. myList = new List<ItemDTO>();
            myList = u;
        }
        //public static void getAllData1()
        //{
        //    List<ItemDTO> list = new List<ItemDTO>();
        //    //list.Add(new ItemDTO(2, "running shoes", "RUNNING SHOES", "Beautiful shoes for you.", "This is explained description", "8.jpg", "3.jpg", "4.jpg", 300, 200, 4, 3));
        //    //list.Add(new ItemDTO(3, "dining table", "DINING TABLE", "A perfect dining table.", "This is explained description", "5.jpg", "5.jpg", "4.jpg", 600, 560, 4, 5));
        //    //list.Add(new ItemDTO(4, "lamp 1", "WALL LAMP", "A decentlamp.", "This is explained description", "6.jpg", "5.jpg", "4.jpg", 500, 420, 4, 4));
        //    //list.Add(new ItemDTO(5, "lamp 2", "WALL LAMP", "A casual lamp.", "This is explained description", "9.jpg", "5.jpg", "4.jpg", 200, 150, 4, 3));
        //    //list.Add(new ItemDTO(6, "necklace", "PEARL AND STONE ANCKLET", "A gorgeous ancklet.", "This is explained description", "10.jpg", "5.jpg", "4.jpg", 300, 280, 4, 4));
        //    //list.Add(new ItemDTO(7, "bangles", "STONES BANGLES", "Stone bangles.", "This is explained description", "11.jpg", "5.jpg", "4.jpg", 200, 150, 4, 3));
        //    //list.Add(new ItemDTO(8, "", "A shirt", "A sweater for casual use.", "", "19.jpg", "", "", 250, 180, 4, 4));
        //    //list.Add(new ItemDTO(9, "", "A Royal Blue shirt", "A shirt for interview.", "", "20.jpg", "", "", 280, 200, 4, 3));
        //    //list.Add(new ItemDTO(10, "", "A Coat", "A decent coat.", "", "26.jpg", "", "", 300, 280, 4, 5));
        //    //list.Add(new ItemDTO(11, "", "A Jacket", "A jacket.", "", "25.jpg", "", "", 280, 190, 4, 3));
        //    //list.Add(new ItemDTO(12, "", "A light brown coat", "", "", "24.jpg", "", "", 250, 190, 4, 4));
        //    //list.Add(new ItemDTO(13, "", "A Formal shirt", "", "", "7.jpg", "", "", 290, 210, 4, 5));
        //    //list.Add(new ItemDTO(14, "", "A Brown Wallet", "A beautiful wallet for your use.", "", "wallet1.jpg", "", "", 50, 30, 4, 4));
        //    //list.Add(new ItemDTO(15, "", "A Black Wallet", "A beautiful wallet for gift.", "", "wallet2.jpg", "", "", 80, 75, 4, 4));
        //    //list.Add(new ItemDTO(16, "", "A Black Beauty", "A preety wallet.", "", "wallet3.jpg", "", "", 70, 60, 4, 4));
        //    //list.Add(new ItemDTO(17, "", "Black shoes", "A beautiful Office shoes.", "", "22.jpg", "", "", 50, 30, 4, 4));
        //    //list.Add(new ItemDTO(18, "", "Jogging Shoes", "joging shoes.", "", "23.jpg", "", "", 80, 75, 4, 4));
        //    //list.Add(new ItemDTO(19, "", "Sports shoes", ".", "", "8.jpg", "", "", 70, 60, 4, 4));
        //    list.Add(new ItemDTO(20, "", "Purple Love", "A Decent party wear.", "", "purple.jpg", "", "", 250, 180, 4, 4));
        //    list.Add(new ItemDTO(21, "", "Red Beauty", "A Decent party wear", "", "gray.jpg", "", "", 280, 200, 4, 3));
        //    list.Add(new ItemDTO(22, "", "Royal Blue", "A Decent party wear.", "", "blue.jpg", "", "", 300, 280, 4, 5));
        //    list.Add(new ItemDTO(23, "", "A Brown Wallet", "A beautiful wallet for your use.", "", "wallet4.jpg", "", "", 50, 30, 4, 4));
        //    list.Add(new ItemDTO(24, "", "A Black Wallet", "A beautiful wallet for gift.", "", "wallet5.jpg", "", "", 80, 75, 4, 4));
        //    list.Add(new ItemDTO(25, "", "A Black Beauty", "A preety wallet.", "", "wallet6.jpg", "", "", 70, 60, 4, 4));
        //    list.Add(new ItemDTO(26, "", "Black shoes", "A beautiful shoes.", "", "blackShoes.png", "", "", 50, 30, 4, 4));
        //    list.Add(new ItemDTO(27, "", "Party wear", "Awesome shoes.", "", "shoes2.png", "", "", 80, 75, 4, 4));
        //    list.Add(new ItemDTO(28, "", "shoes Love", ".", "", "shoes3.png", "", "", 70, 60, 4, 4));
        //    list.Add(new ItemDTO(20, "", "Golden Watch", "Beautiful White and golden watch.", "", "watch4.jpg", "", "", 50, 30, 4, 4));
        //    list.Add(new ItemDTO(21, "", "Silver Watch", "Stylish Watch.", "", "watch5.jpg", "", "", 80, 75, 4, 4));
        //    list.Add(new ItemDTO(22, "", "Stylish watch", "Nice watch", "", "watch6.jpg", "", "", 70, 60, 4, 4));
        //    list.Add(new ItemDTO(20, "", "Traditional Suit", "Beautiful traditional suit.", "", "boy1.jpg", "", "", 50, 30, 4, 4));
        //    list.Add(new ItemDTO(21, "", "Baby boy Cloth", "Stylish Suit.", "", "boy2.jpg", "", "", 80, 75, 4, 4));
        //    list.Add(new ItemDTO(22, "", "Blue baby", "A beautiful baby boy suit", "", "boy3.jpg", "", "", 70, 60, 4, 4));
        //    list.Add(new ItemDTO(20, "", "Traditional Suit", "Beautiful traditional suit.", "", "girl1.jpg", "", "", 50, 30, 4, 4));
        //    list.Add(new ItemDTO(21, "", "Blue Girl", "Stylish Suit.", "", "girl2.jpg", "", "", 80, 75, 4, 4));
        //    list.Add(new ItemDTO(22, "", "Blue baby", "A beautiful baby boy suit", "", "girl3.jpg", "", "", 70, 60, 4, 4));
        //    list.Add(new ItemDTO(20, "", "Traditional Suit", "Beautiful traditional suit.", "", "shoes4.jpg", "", "", 50, 30, 4, 4));
        //    list.Add(new ItemDTO(21, "", "Blue Girl", "Stylish Suit.", "", "shoes5.jpg", "", "", 80, 75, 4, 4));
        //    list.Add(new ItemDTO(22, "", "Blue baby", "A beautiful baby boy suit", "", "shoes6.jpg", "", "", 70, 60, 4, 4));
        //    list.Add(new ItemDTO(20, "", "Traditional Suit", "Beautiful traditional suit.", "", "boy5.jpg", "", "", 50, 30, 4, 4));
        //    list.Add(new ItemDTO(21, "", "Blue Girl", "Stylish Suit.", "", "boy6.jpg", "", "", 80, 75, 4, 4));
        //    list.Add(new ItemDTO(22, "", "Blue baby", "A beautiful baby boy suit", "", "boy4.jpg", "", "", 70, 60, 4, 4));
        //    ItemBO.insertItem(list);
        //}
        public static List<ItemDTO> getAllData()
        {
           return BAL.ItemBO.getAll();
                
        }
        public void add(int i,string k,string n, string d,string ex, string pic1, string pic2,string pic3, int pold, int pnew, int qua, int ra)
        {
            myList.Add(new ItemDTO(i,k,n, d,ex, pic1,  pic2,pic3, pold,pnew,qua, ra));
        }
        public ItemDTO get(string key1)
        {
            foreach(var it in myList)
            {
                if (it.key.Equals(key1))
                    return it;
            }
            return null;
        } 
        public static ItemDTO get(int id,List<ItemDTO> model)
        {
            foreach (var it in model)
            {
                if (it.Id == id)
                    return it;
            }
            return null;
        }
    }
}