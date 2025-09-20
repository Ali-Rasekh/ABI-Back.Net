using System.ComponentModel.DataAnnotations;

namespace AFP_Backend.Modules.Public.Enums
{
    public enum SimpleTemplate
    {
        Male,

        Female
    }

    public enum WithNameTemplate
    {
        [Display(Name = "آقا")]
        Male,

        [Display(Name = "خانم")]
        Female
    }


}
