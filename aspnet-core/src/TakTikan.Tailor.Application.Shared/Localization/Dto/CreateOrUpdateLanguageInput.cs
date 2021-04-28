using System.ComponentModel.DataAnnotations;

namespace TakTikan.Tailor.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}