using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Interface
{
    public interface IFabricCutAppService
    {
        Task CreateFabricCut(FabricCutDto input);

        Task DeleteFabricCut(int id);

        Task<List<FabricCutDto>> FindFabricCut(Expression<Func<FabricCut, bool>> predicate);

        Task<List<FabricCutDto>> GetAllFabricCut();

        Task UpdateFabricCut(FabricCutDto input);
    }
}
