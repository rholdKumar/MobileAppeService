using System;
using System.Collections.Generic;
using EPServices.ViewModels.Profile;
using Xamarin.Forms;

namespace EPServices.Views.Profile
{
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
            BindingContext = new ForgotPasswordViewModel(Navigation);
        }
    }
}
