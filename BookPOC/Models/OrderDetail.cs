using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookPOC.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        public int BookId { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
