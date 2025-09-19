using System;
using System.Collections.Generic;

namespace MaroonModels;

public partial class BiDocumentCategory
{
    public int Pk { get; set; }

    public int CategoryPk { get; set; }

    public int DocumentPk { get; set; }
}
