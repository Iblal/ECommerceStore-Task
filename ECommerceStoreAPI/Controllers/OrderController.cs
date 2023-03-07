using EcommerceStoreBusinessLogic.Interfaces;
using EcommerceStoreDomain.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace EcommerceStoreAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrder order;
        public OrderController(IOrder _orderService) 
        {
            _orderService = order;
        }
        
        [HttpPost]
        public IActionResult CreateOrder([FromBody] JObject orderRequestBody)
        {
            ValidationHelper _validationHelper  = new ValidationHelper();  

            if(!_validationHelper.ValidateOrderRequest(orderRequestBody))
            {
                return BadRequest("Invalid order");
            }
            else
            {
                var orderDTO = orderRequestBody.ToObject<OrderDTO>();
                
                if(orderDTO != null)
                {
                    order.AddOrder(orderDTO);
                }
            }

            return Ok();
        }
    }
}
