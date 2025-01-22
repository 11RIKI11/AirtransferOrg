using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class Aircraft
{
    public int Id { get; set; }

    public int RegistationNumber { get; set; }

    public short ModelId { get; set; }

    public virtual AirlineOwnsAircraft? AirlineOwnsAircraft { get; set; }

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();

    public virtual AircraftModel Model { get; set; } = null!;
}
