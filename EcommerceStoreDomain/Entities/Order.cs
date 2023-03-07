using System.ComponentModel.DataAnnotations;

namespace EcommerceStoreDomain.Entities
{
    public class Order
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public double Total { get; set; }
    }
}
