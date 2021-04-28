using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Interface;

namespace TakTikan.Tailor.Service
{
    public class FabricMaterialAppService : TailorAppServiceBase, IFabricMaterialAppService
    {
        private readonly IRepository<FabricMaterial> _repository;

        public FabricMaterialAppService(IRepository<FabricMaterial> repository)
        {
            this._repository = repository;
        }

        public async Task CreateFabricMaterial(FabricMaterialDto input)
        {
            var model = ObjectMapper.Map<FabricMaterial>(input);

            await this._repository.InsertAsync(model);
        }

        public async Task DeleteFabricMaterial(int id)
        {
            await this._repository.DeleteAsync(id);
        }

        public async Task<List<FabricMaterialDto>> FindFabricMaterial(Expression<Func<FabricMaterial, bool>> predicate)
        {
            var models = await this._repository.GetAllListAsync(predicate);
            var result = ObjectMapper.Map<List<FabricMaterialDto>>(models);

            return result;
        }

        public async Task<List<FabricMaterialDto>> GetAllFabricMaterial()
        {
            var models = await this._repository.GetAllListAsync();
            var result = ObjectMapper.Map<List<FabricMaterialDto>>(models);

            return result;
        }

        public async Task UpdateFabricMaterial(FabricMaterialDto input)
        {
            var model = ObjectMapper.Map<FabricMaterial>(input);
            await this._repository.UpdateAsync(model);
        }
    }
}
