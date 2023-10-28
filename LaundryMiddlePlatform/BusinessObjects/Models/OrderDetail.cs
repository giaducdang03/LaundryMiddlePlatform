using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? ServiceDetailId { get; set; }

    public double? Weight { get; set; }

    public double? UnitPrice { get; set; }

    public double? Price { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ServiceDetail? ServiceDetail { get; set; }
}
