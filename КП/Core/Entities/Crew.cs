using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class Crew
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<CrewAssigment> CrewAssigments { get; set; } = new List<CrewAssigment>();

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
}
