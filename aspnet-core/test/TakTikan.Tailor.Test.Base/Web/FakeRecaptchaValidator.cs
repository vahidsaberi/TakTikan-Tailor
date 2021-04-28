using System.Threading.Tasks;
using TakTikan.Tailor.Security.Recaptcha;

namespace TakTikan.Tailor.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
