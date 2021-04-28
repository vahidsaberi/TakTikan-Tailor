using System.Collections.Generic;
using MvvmHelpers;
using TakTikan.Tailor.Models.NavigationMenu;

namespace TakTikan.Tailor.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}