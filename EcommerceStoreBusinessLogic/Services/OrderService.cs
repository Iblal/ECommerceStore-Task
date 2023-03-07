using AutoMapper;
using EcommerceStoreBusinessLogic.Interfaces;
using EcommerceStoreDomain.DTOs;
using EcommerceStoreDomain.Entities;

namespace EcommerceStoreBusinessLogic.Services
{
    public class OrderService : IOrder
    {

        private readonly IMapper _mapper;

        public OrderService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task AddOrder(OrderDTO orderDTO) 
        {
            var order = _mapper.Map<Order>(orderDTO);

            

            return Task.CompletedTask;
        }
    }

}
