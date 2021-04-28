using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Interface
{
    public interface ISalineStoneAppService
    {
        Task CreateSalineStone(SalineStoneDto input);

        Task DeleteSalineStone(int id);

        Task<List<SalineStoneDto>> FindSalineStone(Expression<Func<SalineStone, bool>> predicate);

        Task<List<SalineStoneDto>> GetAllSalineStone();

        Task UpdateSalineStone(SalineStoneDto input);
    }
}
