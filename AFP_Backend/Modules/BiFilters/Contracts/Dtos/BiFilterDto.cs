using AFP_Backend.Modules.Public.Contracts.Dtos;

namespace AFP_Backend.Modules.BiFilters.Contracts.Dtos;

public class BiFilterDto : BaseDto
{
    public int Pk { get; set; }

    public int DocumentPk { get; set; }

    public byte ComponentType { get; set; }

    public string CodeName { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public short SortOrder { get; set; }

    public string? ApiToGet { get; set; }

    public int? AvailableValuePk { get; set; }

    public bool ShouldDisplay { get; set; }

    public int FilterGroupPk { get; set; }

    public int? ShouldDisplayIfAnotherFilterPk { get; set; }

    public string? ShouldDisplayIfAnotherFilterValue { get; set; }

    public bool CheckAccessToRepairCenter { get; set; }

    public bool CheckAccessToAsset { get; set; }

    public bool CheckAccessToShop { get; set; }
}
