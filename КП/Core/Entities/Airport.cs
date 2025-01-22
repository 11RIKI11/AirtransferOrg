using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class Airport
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public int? BuildingNumb { get; set; }

    public string IataCode { get; set; } = null!;

    public string IcaoCode { get; set; } = null!;

    public virtual ICollection<Flight> FlightArrivalAirports { get; set; } = new List<Flight>();

    public virtual ICollection<Flight> FlightDepartureAirports { get; set; } = new List<Flight>();
}
