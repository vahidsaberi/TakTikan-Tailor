using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
