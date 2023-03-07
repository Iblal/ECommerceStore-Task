using AutoMapper;
using EcommerceStoreDomain.DTOs;
using EcommerceStoreDomain.Entities;

namespace EcommerceStoreBusinessLogic.Mappings
{

    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<OrderDTO, Order>();
        }
    }

}
