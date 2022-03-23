using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using EPServices.Hepler;
using EPServices.Models;
using EPServices.ServiceLayer;
using EPServices.Views.UtilityViews;
using Xamarin.Forms;

namespace EPServices.ViewModels.UtilityViewModel
{
    public class PendingUtilityBillsViewModel: BaseViewModel
    {
        public PendingUtilityBillsViewModel(INavigation navigation) : base(navigation)
        {
            Device.BeginInvokeOnMainThread(async () => {
                try
                {
                    await BindingData();
                }
                catch(Exception ex)
                {

                }
            });
        }
        public async Task BindingData()
        {
            UtilityManagementSL utilityManagementSL = new UtilityManagementSL();
            ReceiveContext<List<UtilityModel>> receiveContext = await utilityManagementSL.PendingUtilityBills();
            if (receiveContext.Status)
            {
                utilityModels =new ObservableCollection<UtilityModel>(receiveContext.Result);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error!", receiveContext.ErrorMessage, "OK");
            }

           

        }
        public ICommand SelectedItemCommand
        {
            get
            {
                return new Command<UtilityModel>(async (x) => {
                    CommonAttribute.SelectedItem = x;
                   string payUrl= await GetPaymentlink();
                    if(!string.IsNullOrEmpty(payUrl))
                     await Navigation.PushAsync(new UtilityOaymentPage(payUrl));
                });
            }
        }
        public ICommand PaidHistoryCommand
        {
            get
            {
                return new Command<UtilityModel>(async (x) => {
                   
                        await Navigation.PushAsync(new UtilityPaidPage());
                });
            }
        }
        public async Task<string> GetPaymentlink()
        {
            UtilityManagementSL utilityManagementSL = new UtilityManagementSL();
            ReceiveContext<string> receiveContext = await utilityManagementSL.UtilityUtilityPay(CommonAttribute.SelectedItem.id, Device.RuntimePlatform, "1234");
            if (receiveContext.Status)
            {
                string payUrl = receiveContext.Result;
                return payUrl;
            }
            else
            {
                return null;
                await Application.Current.MainPage.DisplayAlert("Error!", receiveContext.ErrorMessage, "OK");
            }



        }
        // public ICommand SelectedItemCommand { private set; get; }

        public ObservableCollection<UtilityModel> _utilityModels;
        public ObservableCollection<UtilityModel> utilityModels
        {
            get { return _utilityModels; }
            set
            {
                _utilityModels = value;
                OnPropertyChanged("utilityModels");

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

    }
}
