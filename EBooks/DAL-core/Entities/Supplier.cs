using System.Collections.Generic;

namespace DAL_core.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Product> Products { get; set; }
    }
}
