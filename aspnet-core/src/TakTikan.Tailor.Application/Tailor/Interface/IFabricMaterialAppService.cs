using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Interface
{
    public interface IFabricMaterialAppService
    {
        Task CreateFabricMaterial(FabricMaterialDto input);

        Task DeleteFabricMaterial(int id);

        Task<List<FabricMaterialDto>> FindFabricMaterial(Expression<Func<FabricMaterial, bool>> predicate);

        Task<List<FabricMaterialDto>> GetAllFabricMaterial();

        Task UpdateFabricMaterial(FabricMaterialDto input);
    }
}
