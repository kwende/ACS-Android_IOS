using ACS.Interfaces;
using ACS.Services;
using Xamarin.Forms;

namespace ACS
{
    public partial class App : Application
    {
        public static IAcs Acs { get; private set; }

        public App(IAcs acs)
        {
            Acs = acs;

            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
