using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? StoreId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? StaffId { get; set; }

    public string? Status { get; set; }

    public double? TotalPrice { get; set; }

    public DateTime? PaymentDate { get; set; }

    public virtual Account? Customer { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Account? Staff { get; set; }

    public virtual Store? Store { get; set; }
}
