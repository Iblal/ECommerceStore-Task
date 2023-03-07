using EcommerceStoreDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceStoreBusinessLogic.Interfaces
{
    public interface IOrder
    {
        public Task AddOrder(OrderDTO orderDTO);
    }
}
