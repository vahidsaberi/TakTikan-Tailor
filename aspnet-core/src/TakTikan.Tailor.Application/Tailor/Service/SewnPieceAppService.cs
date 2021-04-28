using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Interface;

namespace TakTikan.Tailor.Service
{
    public class SewnPieceAppService : TailorAppServiceBase, ISewnPieceAppService
    {
        private readonly IRepository<SewnPiece> _repository;

        public SewnPieceAppService(IRepository<SewnPiece> repository)
        {
            this._repository = repository;
        }

        public async Task CreateSewnPiece(SewnPieceDto input)
        {
            var model = ObjectMapper.Map<SewnPiece>(input);

            await this._repository.InsertAsync(model);
        }

        public async Task DeleteSewnPiece(int id)
        {
            await this._repository.DeleteAsync(id);
        }

        public async Task<List<SewnPieceDto>> FindSewnPiece(Expression<Func<SewnPiece, bool>> predicate)
        {
            var models = await this._repository.GetAllListAsync(predicate);
            var result = ObjectMapper.Map<List<SewnPieceDto>>(models);

            return result;
        }

        public async Task<List<SewnPieceDto>> GetAllSewnPiece()
        {
            var models = await this._repository.GetAllListAsync();
            var result = ObjectMapper.Map<List<SewnPieceDto>>(models);

            return result;
        }

        public async Task UpdateSewnPiece(SewnPieceDto input)
        {
            var model = ObjectMapper.Map<SewnPiece>(input);
            await this._repository.UpdateAsync(model);
        }
    }
}
