using System;
using System.Collections.Generic;
using NodaTime;

namespace КП.Core.Entities;

public partial class Flight
{
    public long Id { get; set; }

    public LocalDateTime DepartureTime { get; set; }

    public LocalDateTime? ArrivalTime { get; set; }

    public int DepartureAirportId { get; set; }

    public int ArrivalAirportId { get; set; }

    public int AircraftId { get; set; }

    public long AirlineId { get; set; }

    public short StatusId { get; set; }

    public int CrewId { get; set; }

    public virtual Aircraft Aircraft { get; set; } = null!;

    public virtual Airline Airline { get; set; } = null!;

    public virtual Airport ArrivalAirport { get; set; } = null!;

    public virtual Crew Crew { get; set; } = null!;

    public virtual Airport DepartureAirport { get; set; } = null!;

    public virtual FlightStatus Status { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
