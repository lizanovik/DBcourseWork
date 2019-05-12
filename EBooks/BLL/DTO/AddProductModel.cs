using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class AddProductModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int AmountInStock { get; set; }
        public string Image { get; set; }
        public int ProductCategotyId { get; set; }
        public int SupplierId { get; set; }
    }
}
