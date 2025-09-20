namespace AFP_Backend.MaroonModels;

public partial class BiIndicator
{
    public int Pk { get; set; }

    public string Id { get; set; } = null!;

    public string IndicatorGroupPk { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal AcceptLimit { get; set; }

    public int Weight { get; set; }

    public string? Formula { get; set; }
}
