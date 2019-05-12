using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Customer
    {
        [Key]
        [ForeignKey("User")]
        public string Id { get; set; }
        public List<Order> Orders { get; set; }
        public User User { get; set; }
    }
}
