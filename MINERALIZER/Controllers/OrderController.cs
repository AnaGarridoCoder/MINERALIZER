using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using MINERALIZER_API.iServices;

using MINERALIZER_API.iServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MINERALIZER_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost(Name = "InsertOrder")]
        public int Post([FromBody] OrderItem orderItem) => _orderService.InsertOrder(orderItem);
    }
}