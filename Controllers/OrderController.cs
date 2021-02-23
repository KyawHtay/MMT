using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MMT.interfaces;
using MMT.Models;

namespace MMT.Controllers
{
    public class OrderController : BaseApiController
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;


        }

        [HttpGet]
        public async Task<ActionResult<AppUser>> GetOrder(string email,int Id)
        {
           return await _orderRepository.GetOrderAsync(email,Id);
            
        }

    }
}