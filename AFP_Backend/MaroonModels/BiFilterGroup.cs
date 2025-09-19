using System;
using System.Collections.Generic;

namespace MaroonModels;

public partial class BiFilterGroup
{
    public int Pk { get; set; }

    public string Name { get; set; } = null!;

    public bool ShouldDisplayName { get; set; }
}
