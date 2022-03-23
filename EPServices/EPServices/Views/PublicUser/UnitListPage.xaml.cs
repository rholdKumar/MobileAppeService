using System;
using System.Collections.Generic;
using EPServices.ViewModels.PublicUserViewModel;
using Xamarin.Forms;

namespace EPServices.Views.PublicUser
{
    public partial class UnitListPage : ContentPage
    {
        public UnitListPage(int pid)
        {
            InitializeComponent();
            BindingContext = new UnitListViewModel(Navigation, pid);
        }
    }
}
