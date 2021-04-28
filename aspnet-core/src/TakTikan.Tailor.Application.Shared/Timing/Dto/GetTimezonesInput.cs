using Abp.Configuration;

namespace TakTikan.Tailor.Timing.Dto
{
    public class GetTimezonesInput
    {
        public SettingScopes DefaultTimezoneScope { get; set; }
    }
}
