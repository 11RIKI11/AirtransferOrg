using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class User
{
    public long Id { get; set; }

    public short RoleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Password { get; set; }

    public virtual CrewMember? CrewMember { get; set; }

    public virtual UserRole Role { get; set; } = null!;

    public virtual Staff? Staff { get; set; }

    public virtual ICollection<TicketBooking> TicketBookings { get; set; } = new List<TicketBooking>();
}
