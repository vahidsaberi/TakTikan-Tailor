using System.Collections.Generic;
using TakTikan.Tailor.Authorization.Delegation;
using TakTikan.Tailor.Authorization.Users.Delegation.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
