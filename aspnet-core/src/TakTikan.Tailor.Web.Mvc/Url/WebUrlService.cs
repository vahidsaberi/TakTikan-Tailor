using Abp.Dependency;
using TakTikan.Tailor.Configuration;
using TakTikan.Tailor.Url;

namespace TakTikan.Tailor.Web.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor configurationAccessor) :
            base(configurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:WebSiteRootAddress";
    }
}