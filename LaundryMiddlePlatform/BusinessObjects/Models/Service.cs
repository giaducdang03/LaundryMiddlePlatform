using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public int? StoreId { get; set; }

    public string? Name { get; set; }

    //public double? PricePerWeight { get; set; }

    //public string? WashType { get; set; }

    //public string? WashOption { get; set; }

    //public string? Duration { get; set; }

    public string? Description { get; set; }

    public bool? Status { get; set; }

    //public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<ServiceDetail> ServiceDetails { get; set; } = new List<ServiceDetail>();


    public virtual Store? Store { get; set; }
}
