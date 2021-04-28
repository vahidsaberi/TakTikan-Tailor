using System.Collections.Generic;
using TakTikan.Tailor.Authorization.Users.Dto;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}