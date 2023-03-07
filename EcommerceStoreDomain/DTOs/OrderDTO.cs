using EcommerceStoreDomain.Entities;

namespace EcommerceStoreDomain.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        
        public string Email { get; set; }

        public string Address { get; set; }

        public double Total { get; set; }   
        
        public List<Product> Products { get; set; }
    }
}
