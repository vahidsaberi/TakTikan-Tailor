using Microsoft.Extensions.Configuration;

namespace TakTikan.Tailor.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
