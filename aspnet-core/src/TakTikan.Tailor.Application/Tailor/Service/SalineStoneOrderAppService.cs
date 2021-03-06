using Abp.Authorization;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Authorization;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Interface;

namespace TakTikan.Tailor.Service
{
    [AbpAuthorize(AppPermissions.Pages_TakTikan_SalineStoneOrder)]
    public class SalineStoneOrderAppService : TailorAppServiceBase, ISalineStoneOrderAppService
    {
        private readonly IRepository<SalineStoneOrder> _repository;

        public SalineStoneOrderAppService(IRepository<SalineStoneOrder> repository)
        {
            this._repository = repository;
        }

        public async Task CreateSalineStoneOrder(SalineStoneOrderDto input)
        {
            var model = ObjectMapper.Map<SalineStoneOrder>(input);

            await this._repository.InsertAsync(model);
        }

        public async Task DeleteSalineStoneOrder(int id)
        {
            await this._repository.DeleteAsync(id);
        }

        public async Task<List<SalineStoneOrderDto>> FindSalineStoneOrder(Expression<Func<SalineStoneOrder, bool>> predicate)
        {
            var models = await this._repository.GetAllListAsync(predicate);
            var result = ObjectMapper.Map<List<SalineStoneOrderDto>>(models);

            return result;
        }

        public async Task<List<SalineStoneOrderDto>> GetAllSalineStoneOrder()
        {
            var models = await this._repository.GetAllListAsync();
            var result = ObjectMapper.Map<List<SalineStoneOrderDto>>(models);

            return result;
        }

        public async Task UpdateSalineStoneOrder(SalineStoneOrderDto input)
        {
            var model = ObjectMapper.Map<SalineStoneOrder>(input);
            await this._repository.UpdateAsync(model);
        }
    }
}
