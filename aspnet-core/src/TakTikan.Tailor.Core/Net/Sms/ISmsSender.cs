using System.Threading.Tasks;

namespace TakTikan.Tailor.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}