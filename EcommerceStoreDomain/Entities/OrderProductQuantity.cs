using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceStoreDomain.Entities
{
    public class OrderProductQuantity
    {
        [Required]
        public int Id { get; set;}

        [Required]
        public int OrderId { get; set;}

        [Required]
        public int ProductId { get; set;}

        [Required]
        public int Quantity { get; set; }
    }
}
