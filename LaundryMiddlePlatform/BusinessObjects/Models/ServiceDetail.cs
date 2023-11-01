using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class ServiceDetail
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public string? TypeName { get; set; }
        public string? Type { get; set; }
        public string? WashOption { get; set; }
        public double? PricePerUnit { get; set; }
        public bool? Status { get; set; }
        public TimeSpan? Duration { get; set; }
        public virtual Service? Service { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
