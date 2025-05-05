using System;
using System.Collections.Generic;

namespace Order.Models;

public partial class Order
{
    public Guid OrderId { get; set; }

    public string CustomerName { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
