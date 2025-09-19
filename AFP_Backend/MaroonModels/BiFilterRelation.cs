using System;
using System.Collections.Generic;

namespace MaroonModels;

public partial class BiFilterRelation
{
    public int Pk { get; set; }

    public int BaseFilterPk { get; set; }

    public string Type { get; set; } = null!;

    public string Data { get; set; } = null!;
}
