using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public enum OrderStatus
    {
        New,
        Confirmed,
        Rejected
    }
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderedProduct> OrderDetails { get; set; }
        [Column("Status")]
        public string StatusString
        {
            get { return Status.ToString(); }
            private set { Status = value.ParseEnum<OrderStatus>(); }
        }
        [NotMapped]
        public OrderStatus Status { get; set; }
    }
}
