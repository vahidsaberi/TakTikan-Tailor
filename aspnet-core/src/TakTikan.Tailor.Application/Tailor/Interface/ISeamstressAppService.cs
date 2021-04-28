using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Interface
{
    public interface ISeamstressAppService
    {
        Task CreateSeamstress(SeamstressDto input);

        Task DeleteSeamstress(int id);

        Task<List<SeamstressDto>> FindSeamstress(Expression<Func<Seamstress, bool>> predicate);

        Task<List<SeamstressDto>> GetAllSeamstress();

        Task UpdateSeamstress(SeamstressDto input);
    }
}
