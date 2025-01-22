using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class AirlineAccount
{
    public long UserId { get; set; }

    public long AirlineId { get; set; }

    public virtual User Airline { get; set; } = null!;

    public virtual Airline User { get; set; } = null!;
}
