using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class Baggage
{
    public long Id { get; set; }

    public long BookingId { get; set; }

    public float Weight { get; set; }

    public string Dimensions { get; set; } = null!;

    public short TypeId { get; set; }

    public virtual TicketBooking Booking { get; set; } = null!;

    public virtual BaggageType Type { get; set; } = null!;
}
