using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class ServiceDetail
{
    public int Id { get; set; }

    public int? ServiceId { get; set; }

    public string? TypeName { get; set; }

    public string? Type { get; set; }

    public string? WashOption { get; set; }

    public TimeSpan? Duration { get; set; }

    public double? PricePerUnit { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Service? Service { get; set; }
}
