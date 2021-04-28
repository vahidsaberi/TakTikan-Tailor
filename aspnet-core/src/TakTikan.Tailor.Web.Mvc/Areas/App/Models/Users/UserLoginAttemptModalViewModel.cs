using System.Collections.Generic;
using TakTikan.Tailor.Authorization.Users.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}