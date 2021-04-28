using System.Globalization;

namespace TakTikan.Tailor.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}