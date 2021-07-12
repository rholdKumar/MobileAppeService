using System;
using EPServices.Views.Profile;
using EPServices.Views.PublicUser;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EPServices
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //NavigationPage navigationPage = new NavigationPage(new PublicUserTabbedPage());
            //navigationPage.BarBackgroundColor = ;
            //navigationPage.BarTextColor = MyNavigationBarTextColor;
            MainPage =new NavigationPage(new LoginPage());
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
