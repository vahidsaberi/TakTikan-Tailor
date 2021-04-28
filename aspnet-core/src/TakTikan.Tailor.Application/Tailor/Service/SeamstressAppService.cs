using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Interface;

namespace TakTikan.Tailor.Service
{
    public class SeamstressAppService : TailorAppServiceBase, ISeamstressAppService
    {
        private readonly IRepository<Seamstress> _repository;

        public SeamstressAppService(IRepository<Seamstress> repository)
        {
            this._repository = repository;
        }

        public async Task CreateSeamstress(SeamstressDto input)
        {
            var model = ObjectMapper.Map<Seamstress>(input);

            await this._repository.InsertAsync(model);
        }

        public async Task DeleteSeamstress(int id)
        {
            await this._repository.DeleteAsync(id);
        }

        public async Task<List<SeamstressDto>> FindSeamstress(Expression<Func<Seamstress, bool>> predicate)
        {
            var models = await this._repository.GetAllListAsync(predicate);
            var result = ObjectMapper.Map<List<SeamstressDto>>(models);

            return result;
        }

        public async Task<List<SeamstressDto>> GetAllSeamstress()
        {
            var models = await this._repository.GetAllListAsync();
            var result = ObjectMapper.Map<List<SeamstressDto>>(models);

            return result;
        }

        public async Task UpdateSeamstress(SeamstressDto input)
        {
            var model = ObjectMapper.Map<Seamstress>(input);
            await this._repository.UpdateAsync(model);
        }
    }
}
