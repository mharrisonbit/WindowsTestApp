using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace WindowsTestApp.ViewModels
{
    class HomeViewModel : ViewModelBase
    {
        private readonly IPageDialogService dialog;

        public DelegateCommand SeeThingsBtn { get; }
        public HomeViewModel(INavigationService navigationService, IPageDialogService dialog) : base(navigationService)
        {
            this.dialog = dialog;
            SeeThingsBtn = new DelegateCommand(ShowThingsOnScreen);
            Title = "HomePage";
        }
        
        private void ShowThingsOnScreen()
        {
            this.NavigationService.NavigateAsync("SecondView");
        }
    }
}
