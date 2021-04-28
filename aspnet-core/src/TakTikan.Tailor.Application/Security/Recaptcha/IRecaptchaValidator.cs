using System.Threading.Tasks;

namespace TakTikan.Tailor.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}