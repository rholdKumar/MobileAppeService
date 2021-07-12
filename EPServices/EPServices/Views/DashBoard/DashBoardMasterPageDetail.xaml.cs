using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPServices.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EPServices.Views.DashBoard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardMasterPageDetail : ContentPage
    {
        public DashBoardMasterPageDetail()
        {
            InitializeComponent();
            BindingContext = new DashBoardViewModel(Navigation);
        }
    }
}
