namespace AFP_Backend.MaroonModels;

public partial class BiDocumentCategory
{
    public int Pk { get; set; }

    public int CategoryPk { get; set; }

    public int DocumentPk { get; set; }
}
