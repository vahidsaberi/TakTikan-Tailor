using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Interface
{
    public interface IGenderAppService
    {
        Task CreateGender(GenderDto input);

        Task DeleteGender(int id);

        Task<List<GenderDto>> FindGender(Expression<Func<Gender, bool>> predicate);

        Task<List<GenderDto>> GetAllGender(GenderInput input);

        Task UpdateGender(GenderDto input);
    }
}
