using System.Collections.Generic;
using TakTikan.Tailor.Authorization.Users.Importing.Dto;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
