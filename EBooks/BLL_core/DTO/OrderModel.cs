using DAL_core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_core.DTO
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public List<OrderedProduct> OrderDetails { get; set; }
        public Product Product { get; set; }
    }
}
