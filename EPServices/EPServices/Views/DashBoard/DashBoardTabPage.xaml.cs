using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPServices.Views.Profile;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using EPServices.Views.PublicUser;

namespace EPServices.Views.DashBoard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardTabPage : Xamarin.Forms.TabbedPage
    {
        public DashBoardTabPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            Children.Add(new DashBoardMasterPageDetail());
            Children.Add(new PropertiesHomePage());
            Children.Add(new MyProfilePage());
            Children.Add(new UserSettingsPage());
            

        }
    }
}
