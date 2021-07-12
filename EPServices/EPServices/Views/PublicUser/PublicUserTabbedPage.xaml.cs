using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using EPServices.Views.Profile;

namespace EPServices.Views.PublicUser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PublicUserTabbedPage : Xamarin.Forms.TabbedPage
    {
        public PublicUserTabbedPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            Children.Add(new PropertiesHomePage());
            Children.Add(new LoginPage());
        }
    }
}
