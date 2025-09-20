namespace AFP_Backend.MaroonModels;

public partial class BiAccessGroupLabor
{
    public int Pk { get; set; }

    public int AccessGroupPk { get; set; }

    public int LaborPk { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatorLaborPk { get; set; }
}
