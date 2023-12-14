using System;
using System.Collections.Generic;

namespace tima;

public partial class EquipmentType
{
    public int Id { get; set; }

    public string EqimentType { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<Technician> TechnicianIdTypeEquipment1Navigations { get; } = new List<Technician>();

    public virtual ICollection<Technician> TechnicianIdTypeEquipment2Navigations { get; } = new List<Technician>();

    public virtual ICollection<Technician> TechnicianIdTypeEquipment3Navigations { get; } = new List<Technician>();
}
