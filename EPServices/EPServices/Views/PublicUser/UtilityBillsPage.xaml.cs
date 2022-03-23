using System;
using System.Collections.Generic;
using EPServices.ViewModels.PublicUserViewModel;
using Xamarin.Forms;

namespace EPServices.Views.PublicUser
{
    public partial class UtilityBillsPage : ContentPage
    {
        public UtilityBillsPage(int pid, int uid)
        {
            InitializeComponent();
            BindingContext = new UtilityBillsViewModel(Navigation, pid, uid);
        }
    }
}
