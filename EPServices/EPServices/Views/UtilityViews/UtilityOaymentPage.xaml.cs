using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EPServices.Views.UtilityViews
{
    public partial class UtilityOaymentPage : ContentPage
    {
        public UtilityOaymentPage(string payurl)
        {
            InitializeComponent();
            wvpaymentPage.Source = payurl;
            wvpaymentPage.Navigated += WvpaymentPage_Navigated;
            //upPaymentResponse
        }

        private void WvpaymentPage_Navigated(object sender, WebNavigatedEventArgs e)
        {
            if (e.Url.Contains("upPaymentResponse"))
            {
                btnback.IsVisible = true;
            }
        }

        protected override bool OnBackButtonPressed()
        {
            return false;
        }

        void btnback_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
