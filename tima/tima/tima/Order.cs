using System;
using System.Collections.Generic;

namespace tima;

public partial class Order
{
    public int Id { get; set; }

    public int IdClient { get; set; }

    public int? IdTypeEquipment { get; set; }

    public int IdTypeProblem { get; set; }

    public int IdTechnician { get; set; }

    public int? IdManager { get; set; }

    public int IdStatus { get; set; }

    public DateTime DateOrderOpen { get; set; }

    public DateTime? DateOrderClose { get; set; }

    public string? Comment { get; set; }

    public string? Photo { get; set; }

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual Technician IdTechnicianNavigation { get; set; } = null!;

    public virtual EquipmentType? IdTypeEquipmentNavigation { get; set; }

    public virtual ProblemType IdTypeProblemNavigation { get; set; } = null!;
}
