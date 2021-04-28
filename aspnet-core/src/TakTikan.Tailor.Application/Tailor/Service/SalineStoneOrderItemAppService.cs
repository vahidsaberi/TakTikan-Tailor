using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Interface;

namespace TakTikan.Tailor.Tailor.Service
{
    public class SalineStoneOrderItemAppService : TailorAppServiceBase, ISalineStoneOrderItemAppService
    {
        private readonly IRepository<SalineStoneOrderItem> _repository;

        public SalineStoneOrderItemAppService(IRepository<SalineStoneOrderItem> repository)
        {
            this._repository = repository;
        }

        public async Task CreateSalineStoneOrderItem(SalineStoneOrderItemDto input)
        {
            var model = ObjectMapper.Map<SalineStoneOrderItem>(input);

            await this._repository.InsertAsync(model);
        }

        public async Task DeleteSalineStoneOrderItem(int id)
        {
            await this._repository.DeleteAsync(id);
        }

        public async Task<List<SalineStoneOrderItemDto>> FindSalineStoneOrderItem(Expression<Func<SalineStoneOrderItem, bool>> predicate)
        {
            var models = await this._repository.GetAllListAsync(predicate);
            var result = ObjectMapper.Map<List<SalineStoneOrderItemDto>>(models);

            return result;
        }

        public async Task<List<SalineStoneOrderItemDto>> GetAllSalineStoneOrderItem()
        {
            var models = await this._repository.GetAllListAsync();
            var result = ObjectMapper.Map<List<SalineStoneOrderItemDto>>(models);

            return result;
        }

        public async Task UpdateSalineStoneOrderItem(SalineStoneOrderItemDto input)
        {
            var model = ObjectMapper.Map<SalineStoneOrderItem>(input);
            await this._repository.UpdateAsync(model);
        }
    }
}
