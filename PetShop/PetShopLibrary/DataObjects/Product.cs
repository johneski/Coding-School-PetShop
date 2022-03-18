namespace PetShopLibrary
{

    //interface Product
    public interface IProduct
    {
        decimal ? Price { get; set; }
        decimal ? Cost { get; set; }
        Guid ? ID { get; set; }
    }

    

    public class Product : IProduct
    {
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
        public Guid? ID { get; set; }


        public Product()
        {
            
        }
    }
}