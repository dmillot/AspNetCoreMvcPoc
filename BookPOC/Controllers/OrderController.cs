using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookPOC.Models;
using BookPOC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookPOC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            _orderRepository.CreateOrder(order);
            return View();
        }
    }
}