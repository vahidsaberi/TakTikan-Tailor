using System.Collections.Generic;
using TakTikan.Tailor.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace TakTikan.Tailor.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
