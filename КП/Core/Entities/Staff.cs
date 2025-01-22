using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class Staff
{
    public long Id { get; set; }

    public short? PositionId { get; set; }

    public virtual User IdNavigation { get; set; } = null!;

    public virtual StaffPosition? Position { get; set; }
}
