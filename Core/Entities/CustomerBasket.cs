namespace Core.Entities
{
    public class CustomerBasket
    {
        public CustomerBasket()
        {
        }

        public CustomerBasket(string ıd)
        {
            Id = ıd;
           
        }

        public string Id {get; set;}
        public List<BasketItem> Items {get; set;}=new List<BasketItem>();


    }
}