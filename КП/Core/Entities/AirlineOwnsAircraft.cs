using System;
using System.Collections.Generic;
using NodaTime;

namespace КП.Core.Entities;

public partial class AirlineOwnsAircraft
{
    public long AirlineId { get; set; }

    public int AircraftId { get; set; }

    public LocalDate StartDate { get; set; }

    public virtual Aircraft Aircraft { get; set; } = null!;

    public virtual Airline Airline { get; set; } = null!;
}
