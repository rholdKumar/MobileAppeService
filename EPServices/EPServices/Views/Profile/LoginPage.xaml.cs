using System;
using System.Collections.Generic;
using EPServices.ViewModels.Profile;
using EPServices.Views.DashBoard;
using Xamarin.Forms;

namespace EPServices.Views.Profile
{
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel viewModel { get; set; }
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new LoginViewModel(Navigation);
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordPage());
        }

        void Button_Login(System.Object sender, System.EventArgs e)
        {
           Application.Current.MainPage=new DashBoardMasterPage();
        }
    }
}
