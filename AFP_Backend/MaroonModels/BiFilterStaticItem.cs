using System;
using System.Collections.Generic;

namespace MaroonModels;

public partial class BiFilterStaticItem
{
    public int Pk { get; set; }

    public string StaticGroupPk { get; set; } = null!;

    public string Label { get; set; } = null!;

    public string Value { get; set; } = null!;

    public bool IsActive { get; set; }

    public short SortOrder { get; set; }
}
