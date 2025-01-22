using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class Airline
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public int? BuildingNumb { get; set; }

    public string Ogrn { get; set; } = null!;

    public virtual ICollection<AirlineOwnsAircraft> AirlineOwnsAircrafts { get; set; } = new List<AirlineOwnsAircraft>();

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
}
