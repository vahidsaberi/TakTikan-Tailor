using Xamarin.Forms.Internals;

namespace TakTikan.Tailor.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}