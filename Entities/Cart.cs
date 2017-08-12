namespace Entities
{
    public class Cart
    {
        public int productID { get; set; }
        public int CartID { get; set; }
        public Cart(int a,int b)
        {
            productID = a;
            CartID = b;
        }
    }
}
