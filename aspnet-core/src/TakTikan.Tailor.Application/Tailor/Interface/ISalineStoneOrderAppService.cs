using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Interface
{
    public interface ISalineStoneOrderAppService
    {
        Task CreateSalineStoneOrder(SalineStoneOrderDto input);

        Task DeleteSalineStoneOrder(int id);

        Task<List<SalineStoneOrderDto>> FindSalineStoneOrder(Expression<Func<SalineStoneOrder, bool>> predicate);

        Task<List<SalineStoneOrderDto>> GetAllSalineStoneOrder();

        Task UpdateSalineStoneOrder(SalineStoneOrderDto input);
    }
}
