using System;
using System.Collections.Generic;

namespace MaroonModels;

public partial class BiCategory
{
    public int Pk { get; set; }

    public int? ParentPk { get; set; }

    public string Name { get; set; } = null!;

    public int SortOrder { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public DateTime? DeletedAt { get; set; }

    public bool? IsDeleted { get; set; }
}
