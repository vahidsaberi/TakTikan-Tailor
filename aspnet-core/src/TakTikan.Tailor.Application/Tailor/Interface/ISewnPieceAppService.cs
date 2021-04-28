using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Interface
{
    public interface ISewnPieceAppService
    {
        Task CreateSewnPiece(SewnPieceDto input);

        Task DeleteSewnPiece(int id);

        Task<List<SewnPieceDto>> FindSewnPiece(Expression<Func<SewnPiece, bool>> predicate);

        Task<List<SewnPieceDto>> GetAllSewnPiece();

        Task UpdateSewnPiece(SewnPieceDto input);
    }
}
