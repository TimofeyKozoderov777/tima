using System;
using System.Collections.Generic;

namespace tima;

public partial class Technician
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public int? IdTypeEquipment1 { get; set; }

    public int? IdTypeEquipment2 { get; set; }

    public int? IdTypeEquipment3 { get; set; }

    public string? OtherSkills { get; set; }

    public string? ProfileLink { get; set; }

    public virtual EquipmentType? IdTypeEquipment1Navigation { get; set; }

    public virtual EquipmentType? IdTypeEquipment2Navigation { get; set; }

    public virtual EquipmentType? IdTypeEquipment3Navigation { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
