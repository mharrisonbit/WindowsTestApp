using Prism;
using Prism.Ioc;
using WindowsTestApp.ViewModels;
using WindowsTestApp.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WindowsTestApp
{
    [AutoRegisterForNavigation]
    public partial class App
    {
        /* 
            * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
            * This imposes a limitation in which the App class must have a default constructor. 
            * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
            */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/HomeView");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
        }
    }
}