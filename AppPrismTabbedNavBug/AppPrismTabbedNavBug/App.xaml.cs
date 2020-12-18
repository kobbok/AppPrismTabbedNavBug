using AppPrismTabbedNavBug.ViewModels;
using AppPrismTabbedNavBug.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace AppPrismTabbedNavBug
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("/MainTabbedPage");
            //await NavigationService.NavigateAsync("/TabbedPage?createTab=NavigationPage|TabA&createTab=TabB");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<MainTabbedPage, MainTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<TabbedPage>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TabB, TabBViewModel>();
            containerRegistry.RegisterForNavigation<TabA, TabAViewModel>();
            containerRegistry.RegisterForNavigation<TabASubpage1, TabASubpage1ViewModel>();
            containerRegistry.RegisterForNavigation<TabASubpage2, TabASubpage2ViewModel>();
        }
    }
}
