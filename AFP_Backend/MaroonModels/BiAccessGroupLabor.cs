using System;
using System.Collections.Generic;

namespace MaroonModels;

public partial class BiAccessGroupLabor
{
    public int Pk { get; set; }

    public int AccessGroupPk { get; set; }

    public int LaborPk { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatorLaborPk { get; set; }
}
