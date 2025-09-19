using System;
using System.Collections.Generic;

namespace MaroonModels;

public partial class BiFilterStaticGroup
{
    public string Pk { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ValueType { get; set; } = null!;

    public string? Description { get; set; }
}
