using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class Ticket
{
    public long Id { get; set; }

    public long FlightId { get; set; }

    public short SeatNumber { get; set; }

    public short StatusId { get; set; }

    public long? BookingId { get; set; }

    public virtual TicketBooking? Booking { get; set; }

    public virtual Flight Flight { get; set; } = null!;

    public virtual TicketStatus Status { get; set; } = null!;
}
