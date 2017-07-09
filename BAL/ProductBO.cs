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
                li.Add(new ItemDTO(8, "", "A shirt", "A sweater for casual use.", "", "19.jpg", "", "", 250, 180, 4, 4));
                li.Add(new ItemDTO(9, "", "A Royal Blue shirt", "A shirt for interview.", "", "20.jpg", "", "", 280, 200, 4, 3));
                li.Add(new ItemDTO(10, "", "A Coat", "A decent coat.", "", "26.jpg", "", "", 300, 280, 4, 5));
                li.Add(new ItemDTO(11, "", "A Jacket", "A jacket.", "", "25.jpg", "", "", 280, 190, 4, 3));
                li.Add(new ItemDTO(12, "", "A light brown coat", "", "", "24.jpg", "", "", 250, 190, 4, 4));
                li.Add(new ItemDTO(13, "", "A Formal shirt", "", "", "7.jpg", "", "", 290, 210, 4, 5));
                return li;
            }
            else if(productType.Equals("Wallet"))
            {
                li.Add(new ItemDTO(14, "", "A Brown Wallet", "A beautiful wallet for your use.", "", "wallet1.jpg", "", "", 50, 30, 4, 4));
                li.Add(new ItemDTO(15, "", "A Black Wallet", "A beautiful wallet for gift.", "", "wallet2.jpg", "", "", 80, 75, 4, 4));
                li.Add(new ItemDTO(16, "", "A Black Beauty", "A preety wallet.", "", "wallet3.jpg", "", "", 70, 60, 4, 4));
                return li;    
            }
            else if(productType.Equals("Shoes"))
            {
                li.Add(new ItemDTO(17, "", "Black shoes", "A beautiful Office shoes.", "", "22.jpg", "", "", 50, 30, 4, 4));
                li.Add(new ItemDTO(18, "", "Jogging Shoes", "joging shoes.", "", "23.jpg", "", "", 80, 75, 4, 4));
                li.Add(new ItemDTO(19, "", "Sports shoes", ".", "", "8.jpg", "", "", 70, 60, 4, 4));
                return li;
            }
            else if(productType.Equals("Watches"))
            {
                li.Add(new ItemDTO(17, "", "Black Watch", "Black Watch.", "", "watch3.jpg", "", "", 50, 30, 4, 4));
                li.Add(new ItemDTO(18, "", "Golden Watch", "Golden Watch.", "", "watch2.jpg", "", "", 80, 75, 4, 4));
                li.Add(new ItemDTO(19, "", "Black watch", "Black is love.", "", "watch1.jpg", "", "", 70, 60, 4, 4));
                return li;
            }
            return null;
        }
        private static List<ItemDTO> getWomenData(string productType)
        {
            List<ItemDTO> li = new List<ItemDTO>();
            if (productType.Equals("Cloth"))
            {
                li.Add(new ItemDTO(20, "", "Purple Love", "A Decent party wear.", "", "purple.jpg", "", "", 250, 180, 4, 4));
                li.Add(new ItemDTO(21, "", "Red Beauty", "A Decent party wear", "", "gray.jpg", "", "", 280, 200, 4, 3));
                li.Add(new ItemDTO(22, "", "Royal Blue", "A Decent party wear.", "", "blue.jpg", "", "", 300, 280, 4, 5));
                
                return li;
            }
            else if (productType.Equals("Wallet"))
            {
                li.Add(new ItemDTO(23, "", "A Brown Wallet", "A beautiful wallet for your use.", "", "wallet4.jpg", "", "", 50, 30, 4, 4));
                li.Add(new ItemDTO(24, "", "A Black Wallet", "A beautiful wallet for gift.", "", "wallet5.jpg", "", "", 80, 75, 4, 4));
                li.Add(new ItemDTO(25, "", "A Black Beauty", "A preety wallet.", "", "wallet6.jpg", "", "", 70, 60, 4, 4));
                return li;
            }
            else if (productType.Equals("Shoes"))
            {
                li.Add(new ItemDTO(26, "", "Black shoes", "A beautiful shoes.", "", "blackShoes.png", "", "", 50, 30, 4, 4));
                li.Add(new ItemDTO(27, "", "Party wear", "Awesome shoes.", "", "shoes2.png", "", "", 80, 75, 4, 4));
                li.Add(new ItemDTO(28, "", "shoes Love", ".", "", "shoes3.png", "", "", 70, 60, 4, 4));
                return li;
            }
            else if (productType.Equals("Watch"))
            {
                li.Add(new ItemDTO(20, "", "Golden Watch", "Beautiful White and golden watch.", "", "watch4.jpg", "", "", 50, 30, 4, 4));
                li.Add(new ItemDTO(21, "", "Silver Watch", "Stylish Watch.", "", "watch5.jpg", "", "", 80, 75, 4, 4));
                li.Add(new ItemDTO(22, "", "Stylish watch", "Nice watch", "", "watch6.jpg", "", "", 70, 60, 4, 4));
                return li;
            }
            return null;
        
        }
        private static List<ItemDTO> getKidsData(string productType)
        {
            List<ItemDTO> li = new List<ItemDTO>();
            if(productType.Equals("BoyCloth"))
            {
                li.Add(new ItemDTO(20, "", "Traditional Suit", "Beautiful traditional suit.", "", "boy1.jpg", "", "", 50, 30, 4, 4));
                li.Add(new ItemDTO(21, "", "Baby boy Cloth", "Stylish Suit.", "", "boy2.jpg", "", "", 80, 75, 4, 4));
                li.Add(new ItemDTO(22, "", "Blue baby", "A beautiful baby boy suit", "", "boy3.jpg", "", "", 70, 60, 4, 4));
                return li;
            }
            else if(productType.Equals("GirlCloth"))
            {
                li.Add(new ItemDTO(20, "", "Traditional Suit", "Beautiful traditional suit.", "", "girl1.jpg", "", "", 50, 30, 4, 4));
                li.Add(new ItemDTO(21, "", "Blue Girl", "Stylish Suit.", "", "girl2.jpg", "", "", 80, 75, 4, 4));
                li.Add(new ItemDTO(22, "", "Blue baby", "A beautiful baby boy suit", "", "girl3.jpg", "", "", 70, 60, 4, 4));
                return li;
            }
            else if(productType.Equals("Shoes"))
            {
                li.Add(new ItemDTO(20, "", "Traditional Suit", "Beautiful traditional suit.", "", "shoes4.jpg", "", "", 50, 30, 4, 4));
                li.Add(new ItemDTO(21, "", "Blue Girl", "Stylish Suit.", "", "shoes5.jpg", "", "", 80, 75, 4, 4));
                li.Add(new ItemDTO(22, "", "Blue baby", "A beautiful baby boy suit", "", "shoes6.jpg", "", "", 70, 60, 4, 4));
                li.Add(new ItemDTO(20, "", "Traditional Suit", "Beautiful traditional suit.", "", "boy5.jpg", "", "", 50, 30, 4, 4));
                li.Add(new ItemDTO(21, "", "Blue Girl", "Stylish Suit.", "", "boy6.jpg", "", "", 80, 75, 4, 4));
                li.Add(new ItemDTO(22, "", "Blue baby", "A beautiful baby boy suit", "", "boy4.jpg", "", "", 70, 60, 4, 4));
                return li;
            }
            return null;
        }
    }
}
