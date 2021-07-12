using System;
using System.Collections.Generic;
using EPServices.ViewModels.Profile;
using Xamarin.Forms;

namespace EPServices.Views.Profile
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new SignUpViewModel(Navigation);
        }
    }
}
