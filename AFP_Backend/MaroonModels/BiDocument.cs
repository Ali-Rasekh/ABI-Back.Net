using System;
using System.Collections.Generic;

namespace MaroonModels;

public partial class BiDocument
{
    public int Pk { get; set; }

    public string? Abiid { get; set; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// Report=1; Dashboard=2;
    /// </summary>
    public byte Type { get; set; }

    public bool IsSystemic { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public int? MasterPk { get; set; }

    public int ParentPk { get; set; }

    public int BasePk { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int CreatorLaborPk { get; set; }

    public int? UpdatorLaborPk { get; set; }
}
