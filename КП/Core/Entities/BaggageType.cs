using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class BaggageType
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Baggage> Baggages { get; set; } = new List<Baggage>();
}
