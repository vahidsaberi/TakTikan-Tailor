using Abp.Authorization;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Authorization;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Interface;

namespace TakTikan.Tailor.Service
{
    [AbpAuthorize(AppPermissions.Pages_TakTikan_Gender)]
    public class GenderAppService : TailorAppServiceBase, IGenderAppService
    {
        private readonly IRepository<Gender> _repository;

        public GenderAppService(IRepository<Gender> repository)
        {
            this._repository = repository;
        }

        public async Task CreateGender(GenderDto input)
        {
            var model = ObjectMapper.Map<Gender>(input);

            await this._repository.InsertAsync(model);
        }

        public async Task DeleteGender(int id)
        {
            await this._repository.DeleteAsync(id);
        }

        public async Task<List<GenderDto>> FindGender(Expression<Func<Gender, bool>> predicate)
        {
            var models = await this._repository.GetAllListAsync(predicate);
            var result = ObjectMapper.Map<List<GenderDto>>(models);

            return result;
        }

        public async Task<List<GenderDto>> GetAllGender(GenderInput input)
        {
            var models = await this._repository.GetAllListAsync();

            //if (input.TargetValueFilter == "EMPTY")
            //{
            //    models = models.Where(s => s.TargetValue.IsNullOrEmpty());
            //}

            var result = ObjectMapper.Map<List<GenderDto>>(models);

            return result;
        }

        public async Task UpdateGender(GenderDto input)
        {
            var model = ObjectMapper.Map<Gender>(input);
            await this._repository.UpdateAsync(model);
        }
    }
}
