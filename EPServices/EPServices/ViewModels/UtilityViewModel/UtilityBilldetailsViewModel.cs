using System;
using System.Threading.Tasks;
using EPServices.Hepler;
using EPServices.Models;
using EPServices.ServiceLayer;
using EPServices.Views.UtilityViews;
using Xamarin.Forms;

namespace EPServices.ViewModels.UtilityViewModel
{
    public class UtilityBilldetailsViewModel : BaseViewModel
    {
        public UtilityBilldetailsViewModel(INavigation navigation) : base(navigation)
        {
            Device.BeginInvokeOnMainThread(async () => {
                try
                {
                    await BindingData();
                }
                catch (Exception ex)
                {

                }
            });
        }
        public async Task BindingData()
        {
            UtilityManagementSL utilityManagementSL = new UtilityManagementSL();
            ReceiveContext<string> receiveContext = await utilityManagementSL.UtilityUtilityPay(CommonAttribute.SelectedItem.id,Device.RuntimePlatform,"1234");
            if (receiveContext.Status)
            {
                string payUrl = receiveContext.Result;
              await  Navigation.PushAsync(new UtilityOaymentPage(payUrl));
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error!", receiveContext.ErrorMessage, "OK");
            }



        }
    }
}
