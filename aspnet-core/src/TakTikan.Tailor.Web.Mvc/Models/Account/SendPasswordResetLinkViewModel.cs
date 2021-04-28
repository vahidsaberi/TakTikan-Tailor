using System.ComponentModel.DataAnnotations;

namespace TakTikan.Tailor.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}