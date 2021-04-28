using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Interface
{
    public interface IFabricRollAppService
    {
        Task CreateFabricRoll(FabricRollDto input);

        Task DeleteFabricRoll(int id);

        Task<List<FabricRollDto>> FindFabricRoll(Expression<Func<FabricRoll, bool>> predicate);

        Task<List<FabricRollDto>> GetAllFabricRoll();

        Task UpdateFabricRoll(FabricRollDto input);
    }
}
