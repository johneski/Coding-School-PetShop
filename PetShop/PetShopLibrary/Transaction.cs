namespace PetShopLibrary
{
    public interface ITransaction
    {
        Guid ID { get; set; }
        DateTime Date { get; set; }
        Guid CustomerID { get; set; }
        Guid EmployeeID { get; set; }
        Guid PetID { get; set; }
        decimal PetPrice { get; set; }
        Guid PetFoodID { get; set; }
        int PetFoodQty { get; set; }
        decimal PetFoodPrice { get; set; }
        decimal TotalPrice { get; set; }

    }

    public class Transaction : ITransaction
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid PetID { get; set; }
        public decimal PetPrice { get; set; }
        public Guid PetFoodID { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}