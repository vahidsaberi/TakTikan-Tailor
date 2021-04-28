using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using TakTikan.Tailor.MultiTenancy.Accounting.Dto;

namespace TakTikan.Tailor.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
