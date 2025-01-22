using System;
using System.Collections.Generic;
using NodaTime;

namespace КП.Core.Entities;

public partial class TicketBooking
{
    public long Id { get; set; }

    public long BookingId { get; set; }

    public long PassengerId { get; set; }

    public LocalDateTime BookingDate { get; set; }

    public long UserId { get; set; }

    public short StatusId { get; set; }

    public virtual ICollection<Baggage> Baggages { get; set; } = new List<Baggage>();

    public virtual Passenger Passenger { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual BookingStatus Status { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual User User { get; set; } = null!;
}
