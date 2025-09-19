using System;
using System.Collections.Generic;

namespace MaroonModels;

public partial class BiSavedFilterValue
{
    public int Pk { get; set; }

    public int SavedFilterPk { get; set; }

    public int FilterPk { get; set; }

    public string Value { get; set; } = null!;

    public byte ValueType { get; set; }
}
