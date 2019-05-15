
namespace DAL_core.Entities
{
    public class OrderedProduct
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public double PricePerItem { get; set; }
        public int Quantity { get; set; }
    }
}
