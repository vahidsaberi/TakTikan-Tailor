using Abp.Domain.Repositories;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Interface;

namespace TakTikan.Tailor.Service
{
    public class FabricCutAppService : TailorAppServiceBase, IFabricCutAppService
    {
        private readonly IRepository<FabricCut> _repository;

        public FabricCutAppService(IRepository<FabricCut> repository)
        {
            this._repository = repository;
        }

        public async Task CreateFabricCut(FabricCutDto input)
        {
            try
            {
                var model = ObjectMapper.Map<FabricCut>(input);

                await this._repository.InsertAsync(model);
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message);
            }
        }

        public async Task DeleteFabricCut(int id)
        {
            await this._repository.DeleteAsync(id);
        }


        public async Task<List<FabricCutDto>> FindFabricCut(Expression<Func<FabricCut, bool>> predicate)
        {
            var models = await this._repository.GetAllListAsync(predicate);
            var result = ObjectMapper.Map<List<FabricCutDto>>(models);

            return result;
        }

        public async Task<List<FabricCutDto>> GetAllFabricCut()
        {
            var models = await this._repository.GetAllListAsync();
            var result = ObjectMapper.Map<List<FabricCutDto>>(models);

            return result;
        }

        public async Task UpdateFabricCut(FabricCutDto input)
        {
            var model = ObjectMapper.Map<FabricCut>(input);
            await this._repository.UpdateAsync(model);
        }
    }
}
