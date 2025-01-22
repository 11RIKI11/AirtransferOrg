using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class Payment
{
    public long Id { get; set; }

    public long BookingId { get; set; }

    public float Amount { get; set; }

    public short PaymentMethodId { get; set; }

    public virtual TicketBooking Booking { get; set; } = null!;

    public virtual PaymentMethod PaymentMethod { get; set; } = null!;
}
