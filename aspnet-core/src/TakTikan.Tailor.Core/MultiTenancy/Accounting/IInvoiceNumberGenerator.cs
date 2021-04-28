using System.Threading.Tasks;
using Abp.Dependency;

namespace TakTikan.Tailor.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}