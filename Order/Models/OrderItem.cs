﻿using System;
using System.Collections.Generic;

namespace Order.Models;

public partial class OrderItem
{
    public Guid OrderItemId { get; set; }

    public Guid OrderId { get; set; }

    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public virtual Order Order { get; set; } = null!;
}
