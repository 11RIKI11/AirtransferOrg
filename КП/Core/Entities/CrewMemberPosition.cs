﻿using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class CrewMemberPosition
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CrewAssigment> CrewAssigments { get; set; } = new List<CrewAssigment>();
}
