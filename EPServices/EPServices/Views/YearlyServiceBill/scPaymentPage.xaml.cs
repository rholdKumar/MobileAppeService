using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EPServices.DependencyServices;
using EPServices.Models;
using EPServices.ServiceLayer;
using Xamarin.Forms;

namespace EPServices.Views.YearlyServiceBill
{
    public partial class scPaymentPage : ContentPage
    {
        public int wid { get; set; }
        public int nid { get; set; }
        public decimal amount { get; set; }
        public string paytype { get; set; }
        public scPaymentPage(int wid, int nid, decimal amount,string paytype)
        {
            InitializeComponent();
            this.wid = wid;
            this.nid = nid;
            this.amount = amount;
            this.paytype = paytype;
            var hud = DependencyService.Get<IEPProgress>();
            hud.Show();
            wvpaymentPage.Navigated += WvpaymentPage_Navigated;

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await BindingData(wid, nid, amount, paytype);
        }
        public async Task BindingData(int wid, int nid, decimal amount,string paytype)
        {
            ServicesManagementSL userManagementSL = new ServicesManagementSL();
            ReceiveContext<string> receiveContext = await userManagementSL.PayPartially(wid,nid,amount, paytype,Device.RuntimePlatform,"2314");
            if (receiveContext.Status)
            {
                wvpaymentPage.Source = receiveContext.Result;
            }

        }
        private void WvpaymentPage_Navigated(object sender, WebNavigatedEventArgs e)
        {
            var hud = DependencyService.Get<IEPProgress>();
            hud.Dismiss();
            if (e.Url.Contains("PaymentResponse?ref"))
            {
                btnback.IsVisible = true;
            }
        }

        void btnback_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
