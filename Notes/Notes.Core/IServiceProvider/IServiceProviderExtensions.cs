
namespace Notes.Core.IServiceProvider
{
    public static class IServiceProviderExtensions
    {
        public static T GetService<T>(this System.IServiceProvider serviceProvider)
        {
            return (T)serviceProvider.GetService(typeof(T))!;
        }
    }
}
