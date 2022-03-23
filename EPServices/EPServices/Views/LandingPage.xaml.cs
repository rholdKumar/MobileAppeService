using System;
using System.Collections.Generic;
using EPServices.Views.Profile;
using EPServices.Views.PublicUser;
using Xamarin.Forms;

namespace EPServices.Views
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        void TapGestureRecognizer_Tapped_2(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PropertyListPage());
        }

        void TapGestureRecognizer_Tapped_3(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PropertyListPage());
        }

        void TapGestureRecognizer_Tapped_4(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PropertyListPage());
        }
    }
}
