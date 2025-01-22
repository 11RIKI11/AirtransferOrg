using System;
using System.Collections.Generic;
using NodaTime;

namespace КП.Core.Entities;

public partial class Passenger
{
    public long Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public LocalDate? Birthdate { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string DocumentNumber { get; set; } = null!;

    public short DocumentTypeId { get; set; }

    public virtual DocumentType DocumentType { get; set; } = null!;

    public virtual ICollection<TicketBooking> TicketBookings { get; set; } = new List<TicketBooking>();
}
