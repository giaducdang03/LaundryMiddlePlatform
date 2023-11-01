using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Store
{
    public int StoreId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public int? ManagementId { get; set; }

    public bool? IsAvailable { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    public virtual Account? Manager { get; set; }
}
