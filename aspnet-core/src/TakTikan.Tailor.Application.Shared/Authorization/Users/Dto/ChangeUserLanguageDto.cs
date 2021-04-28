using System.ComponentModel.DataAnnotations;

namespace TakTikan.Tailor.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
