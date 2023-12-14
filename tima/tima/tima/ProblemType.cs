using System;
using System.Collections.Generic;

namespace tima;

public partial class ProblemType
{
    public int Id { get; set; }

    public string ProblemType1 { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
