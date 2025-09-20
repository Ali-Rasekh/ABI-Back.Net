namespace AFP_Backend.MaroonModels;

public partial class BiCalendar
{
    public DateOnly MiladiDate { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public int ShamsiYear { get; set; }

    public int ShamsiMonth { get; set; }

    public string? ShamsiMonthName { get; set; }

    public int? ShamsiSeasonNumber { get; set; }

    public string? ShamsiSeasonName { get; set; }

    public int ShamsiDayOfMonth { get; set; }

    public int ShamsiDayOfYear { get; set; }

    public int ShamsiDayOfWeek { get; set; }

    public int ShamsiWeekOfYear { get; set; }

    public string ShamsiDayOfWeekName { get; set; } = null!;
}
