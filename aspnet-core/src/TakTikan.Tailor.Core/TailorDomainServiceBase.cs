using Abp.Domain.Services;

namespace TakTikan.Tailor
{
    public abstract class TailorDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected TailorDomainServiceBase()
        {
            LocalizationSourceName = TailorConsts.LocalizationSourceName;
        }
    }
}
