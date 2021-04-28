using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Interface;

namespace TakTikan.Tailor.Service
{
    public class SalineStoneAppService : TailorAppServiceBase, ISalineStoneAppService
    {
        private readonly IRepository<SalineStone> _repository;

        public SalineStoneAppService(IRepository<SalineStone> repository)
        {
            this._repository = repository;
        }

        public async Task CreateSalineStone(SalineStoneDto input)
        {
            var model = ObjectMapper.Map<SalineStone>(input);

            await this._repository.InsertAsync(model);
        }

        public async Task DeleteSalineStone(int id)
        {
            await this._repository.DeleteAsync(id);
        }

        public async Task<List<SalineStoneDto>> FindSalineStone(Expression<Func<SalineStone, bool>> predicate)
        {
            var models = await this._repository.GetAllListAsync(predicate);
            var result = ObjectMapper.Map<List<SalineStoneDto>>(models);

            return result;
        }

        public async Task<List<SalineStoneDto>> GetAllSalineStone()
        {
            var models = await this._repository.GetAllListAsync();
            var result = ObjectMapper.Map<List<SalineStoneDto>>(models);

            return result;
        }

        public async Task UpdateSalineStone(SalineStoneDto input)
        {
            var model = ObjectMapper.Map<SalineStone>(input);
            await this._repository.UpdateAsync(model);
        }
    }
}
