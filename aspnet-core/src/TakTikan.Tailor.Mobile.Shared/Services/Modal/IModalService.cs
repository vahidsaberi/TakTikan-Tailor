using System.Threading.Tasks;
using TakTikan.Tailor.Views;
using Xamarin.Forms;

namespace TakTikan.Tailor.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
