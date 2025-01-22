using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class AircraftModel
{
    public short Id { get; set; }

    public string? ModelName { get; set; }

    public int? Capacity { get; set; }

    public virtual ICollection<Aircraft> Aircraft { get; set; } = new List<Aircraft>();
}
