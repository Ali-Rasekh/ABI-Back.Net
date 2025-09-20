namespace AFP_Backend.MaroonModels;

public partial class BiSavedFilter
{
    public int Pk { get; set; }

    public int LaborPk { get; set; }

    public int DocumentPk { get; set; }

    public string Name { get; set; } = null!;

    public bool IsSystem { get; set; }

    public bool IsLaborDefault { get; set; }
}
