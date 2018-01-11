using Prism.Unity;
using Xamarin.Forms;

namespace QRReader
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            
            //NavigationService.NavigateAsync("MainPage/Reading");
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {

            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            
        }
    }
}
