using System;
using System.Collections.Generic;

namespace MaroonModels;

public partial class BiFilterAvailableValue
{
    public int Pk { get; set; }

    public string Name { get; set; } = null!;

    public short SourceType { get; set; }

    public string SourceName { get; set; } = null!;

    public string? LabelField { get; set; }

    public string? ValueField { get; set; }

    public string ValueType { get; set; } = null!;

    public string? OrderBy { get; set; }

    public bool NeedLaborPkParam { get; set; }

    public bool UseCache { get; set; }
}
