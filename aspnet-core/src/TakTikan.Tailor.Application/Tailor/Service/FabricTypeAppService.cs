using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Interface;

namespace TakTikan.Tailor.Service
{
    public class FabricTypeAppService : TailorAppServiceBase, IFabricTypeAppService
    {
        private readonly IRepository<FabricType> _repository;

        public FabricTypeAppService(IRepository<FabricType> repository)
        {
            this._repository = repository;
        }

        public async Task CreateFabricType(FabricTypeDto input)
        {
            var model = ObjectMapper.Map<FabricType>(input);

            await this._repository.InsertAsync(model);
        }

        public async Task DeleteFabricType(int id)
        {
            await this._repository.DeleteAsync(id);
        }

        public async Task<List<FabricTypeDto>> FindFabricType(Expression<Func<FabricType, bool>> predicate)
        {
            var models = await this._repository.GetAllListAsync(predicate);
            var result = ObjectMapper.Map<List<FabricTypeDto>>(models);

            return result;
        }

        public async Task<List<FabricTypeDto>> GetAllFabricType()
        {
            var models = await this._repository.GetAllListAsync();
            var result = ObjectMapper.Map<List<FabricTypeDto>>(models);

            return result;
        }

        public async Task UpdateFabricType(FabricTypeDto input)
        {
            var model = ObjectMapper.Map<FabricType>(input);
            await this._repository.UpdateAsync(model);
        }
    }
}
