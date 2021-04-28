using System.Threading.Tasks;

namespace TakTikan.Tailor.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
