using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class CrewMember
{
    public long Id { get; set; }

    public string? Qualification { get; set; }

    public virtual ICollection<CrewAssigment> CrewAssigments { get; set; } = new List<CrewAssigment>();

    public virtual User IdNavigation { get; set; } = null!;
}
