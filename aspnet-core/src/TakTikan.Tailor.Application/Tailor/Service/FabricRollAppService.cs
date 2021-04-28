using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Interface;

namespace TakTikan.Tailor.Service
{
    public class FabricRollAppService : TailorAppServiceBase, IFabricRollAppService
    {
        private readonly IRepository<FabricRoll> _repository;

        public FabricRollAppService(IRepository<FabricRoll> repository)
        {
            this._repository = repository;
        }

        public async Task CreateFabricRoll(FabricRollDto input)
        {
            var model = ObjectMapper.Map<FabricRoll>(input);

            await this._repository.InsertAsync(model);
        }

        public async Task DeleteFabricRoll(int id)
        {
            await this._repository.DeleteAsync(id);
        }

        public async Task<List<FabricRollDto>> FindFabricRoll(Expression<Func<FabricRoll, bool>> predicate)
        {
            var models = await this._repository.GetAllListAsync(predicate);
            var result = ObjectMapper.Map<List<FabricRollDto>>(models);

            return result;
        }

        public async Task<List<FabricRollDto>> GetAllFabricRoll()
        {
            var models = await this._repository.GetAllListAsync();
            var result = ObjectMapper.Map<List<FabricRollDto>>(models);

            return result;
        }

        public async Task UpdateFabricRoll(FabricRollDto input)
        {
            var model = ObjectMapper.Map<FabricRoll>(input);
            await this._repository.UpdateAsync(model);
        }
    }
}
