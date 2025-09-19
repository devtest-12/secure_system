using Microsoft.AspNetCore.Mvc;
using Scoops2GoAPI.Services;

namespace Scoops2GoAPI.Controllers;

[ApiController]
[Route("orders")]
public class OrdersController : ControllerBase
{
    private readonly OrderService _orders;

    public OrdersController(OrderService orders) => _orders = orders;

    [HttpGet]
    public IActionResult GetOrders(int userId)
        => Ok(_orders.GetOrders(userId));

    [HttpPost]
    public IActionResult CreateOrder(int userId, string item, int qty)
    {
        _orders.CreateOrder(userId, item, qty);
        return Ok("Order created");
    }
}

