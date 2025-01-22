using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class PaymentMethod
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
