using System;
using System.Threading.Tasks;
using EPServices.Hepler;
using EPServices.Models;
using EPServices.ServiceLayer;
using Xamarin.Forms;

namespace EPServices.ViewModels.UtilityViewModel
{
    public class UtilityDetailsViewModel : BaseViewModel
    {
        public UtilityDetailsViewModel(INavigation navigation) : base(navigation)
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
            ReceiveContext<UtilityModel> receiveContext = await utilityManagementSL.UtilityDetails(CommonAttribute.SelectedItem.id);
            if (receiveContext.Status)
            {
                SelectedItem = receiveContext.Result;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error!", receiveContext.ErrorMessage, "OK");
                await  Navigation.PopAsync();
            }



        }
        public UtilityModel _SelectedItem;
        public UtilityModel SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                OnPropertyChanged("SelectedItem");

            }
        }
        public string _PaymentStatus;
        public string PaymentStatus
        {
            get {
                if (SelectedItem?.PaymentStatusID == 5)
                    return "PAYMENT PAID SUCCESSFULLY";
                else 
                    return SelectedItem.PaymentStatus;

                    }
             
            set
            {
                _PaymentStatus = value;
                OnPropertyChanged("PaymentStatus");

            }
        }
    }
}
