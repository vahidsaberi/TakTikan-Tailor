using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Interface
{
    public interface ISalineStoneOrderItemAppService
    {
        Task CreateSalineStoneOrderItem(SalineStoneOrderItemDto input);

        Task DeleteSalineStoneOrderItem(int id);

        Task<List<SalineStoneOrderItemDto>> FindSalineStoneOrderItem(Expression<Func<SalineStoneOrderItem, bool>> predicate);

        Task<List<SalineStoneOrderItemDto>> GetAllSalineStoneOrderItem();

        Task UpdateSalineStoneOrderItem(SalineStoneOrderItemDto input);
    }
}
