using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class StaffPosition
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
