using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory ProductCategory { get; set; }
        [ForeignKey("ProductCategory")]
        public int ProductCategotyId { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
        public int AmountInStock { get; set; }
        public string Image { get; set; }
        public bool ProductInStock { get; set; }
        public List<OrderedProduct> Order { get; set; }
    }
}
