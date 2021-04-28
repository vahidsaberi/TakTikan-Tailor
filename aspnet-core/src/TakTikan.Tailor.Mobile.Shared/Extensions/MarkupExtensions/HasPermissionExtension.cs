using System;
using TakTikan.Tailor.Core;
using TakTikan.Tailor.Core.Dependency;
using TakTikan.Tailor.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TakTikan.Tailor.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}