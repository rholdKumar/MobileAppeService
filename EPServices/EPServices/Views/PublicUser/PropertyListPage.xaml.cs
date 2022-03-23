using System;
using System.Collections.Generic;
using EPServices.ViewModels.PublicUserViewModel;
using Xamarin.Forms;

namespace EPServices.Views.PublicUser
{
    public partial class PropertyListPage : ContentPage
    {
        public PropertyListPage()
        {
            InitializeComponent();
            BindingContext = new PropertyListViewModel(Navigation);
        }
    }
}
