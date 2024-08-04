using Notes.Core.IServiceProvider;
using Notes.MVVM;
using Notes.Views;
using Notes.Views.Note;
using Notes.Views.RouteMap;
using Prism.Regions;
using ReactiveUI;
using System;
using System.Windows.Input;

namespace Notes.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IRegionManager _regionManager;
        private const string _regionName = "ContentRegion";

        #region ICommand
        public ICommand SwitchToNoteCommand { get; }
        public ICommand SwitchToRouteMapCommand { get; }
        public ICommand SwitchToStartMenuCommand { get; }
        #endregion

        public MainViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _regionManager = serviceProvider.GetService<IRegionManager>();

            NavigateToStartMenu();
            SwitchToNoteCommand = ReactiveCommand.Create(NavigateToNote);
            SwitchToRouteMapCommand = ReactiveCommand.Create(NavigateToRouteMap);
            SwitchToStartMenuCommand = ReactiveCommand.Create(NavigateToStartMenu);
        }

        private void NavigateToNote()
            => _regionManager.RequestNavigate(_regionName, nameof(NoteView));

        private void NavigateToRouteMap() 
            => _regionManager.RequestNavigate(_regionName, nameof(RouteMapView));

        private void NavigateToStartMenu() 
            => _regionManager.RequestNavigate(_regionName, nameof(StartMenuView));
    }
}
