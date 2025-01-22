using System;
using System.Collections.Generic;

namespace КП.Core.Entities;

public partial class CrewAssigment
{
    public int CrewId { get; set; }

    public long CrewMemberId { get; set; }

    public short MemberPositionId { get; set; }

    public virtual Crew Crew { get; set; } = null!;

    public virtual CrewMember CrewMember { get; set; } = null!;

    public virtual CrewMemberPosition MemberPosition { get; set; } = null!;
}
