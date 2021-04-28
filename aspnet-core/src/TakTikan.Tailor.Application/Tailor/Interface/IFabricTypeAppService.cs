using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Interface
{
    public interface IFabricTypeAppService
    {
        Task CreateFabricType(FabricTypeDto input);

        Task DeleteFabricType(int id);

        Task<List<FabricTypeDto>> FindFabricType(Expression<Func<FabricType, bool>> predicate);

        Task<List<FabricTypeDto>> GetAllFabricType();

        Task UpdateFabricType(FabricTypeDto input);
    }
}
