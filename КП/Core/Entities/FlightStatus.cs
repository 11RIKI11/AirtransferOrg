using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class FlightStatus
{
    public short Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
}
