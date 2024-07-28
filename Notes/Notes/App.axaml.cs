using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Notes.Views;
using Prism.DryIoc;
using Prism.Ioc;

namespace Notes
{
    public partial class App : PrismApplication
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);

            // Initializes Prism.Avalonia - DO NOT REMOVE
            base.Initialize();
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
            {
                desktopLifetime.MainWindow = new MainWindow();
            }
            else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewLifetime)
            {
                singleViewLifetime.MainView = new MainView();
            }

#if DEBUG
            this.AttachDevTools();
#endif
            base.OnFrameworkInitializationCompleted();
        }

        protected override AvaloniaObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}