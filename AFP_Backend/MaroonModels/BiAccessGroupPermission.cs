namespace AFP_Backend.MaroonModels;

public partial class BiAccessGroupPermission
{
    public int Pk { get; set; }

    public int AccessGroupPk { get; set; }

    /// <summary>
    /// Enum
    /// </summary>
    public int PermissionPk { get; set; }

    /// <summary>
    /// DocumentPK OR CategoryPK
    /// </summary>
    public int? RefPk { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatorLaborPk { get; set; }
}
