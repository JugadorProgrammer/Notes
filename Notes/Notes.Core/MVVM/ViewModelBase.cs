using ReactiveUI;

namespace Notes.MVVM
{
    public class ViewModelBase : ReactiveObject
    {
        protected readonly IServiceProvider _serviceProvider;
        public ViewModelBase(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
    }
}
