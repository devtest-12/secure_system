namespace Scoops2GoAPI.Models;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string ItemName { get; set; } = "";
    public int Quantity { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

