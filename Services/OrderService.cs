using Scoops2GoAPI.Models;

namespace Scoops2GoAPI.Services;

public class OrderService
{
    private List<Order> _orders = new();

    public IEnumerable<Order> GetOrders(int userId)
        => _orders.Where(o => o.UserId == userId);

    public void CreateOrder(int userId, string item, int qty)
        => _orders.Add(new Order { Id = _orders.Count+1, UserId = userId, ItemName = item, Quantity = qty });
}

