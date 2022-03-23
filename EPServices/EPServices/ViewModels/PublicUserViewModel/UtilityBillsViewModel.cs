using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using EPServices.Models;
using EPServices.ServiceLayer;
using Xamarin.Forms;

namespace EPServices.ViewModels.PublicUserViewModel
{
    public class UtilityBillsViewModel : BaseViewModel
    {
        public UtilityBillsViewModel(INavigation navigation, int pid,int uid) : base(navigation)
        {
            this.pid = pid;
            this.uid = uid;
            Device.BeginInvokeOnMainThread(async () => {
                await BindingData();
            });
        }
        public int pid { get; set; }
        public int uid { get; set; }
        public async Task BindingData()
        {
            UserManagementSL userManagementSL = new UserManagementSL();
            ReceiveContext<List<UtilityModel>> receiveContext = await userManagementSL.GetUtilityBills(pid,uid);
            if (receiveContext.Status)
            {
                UtiltiyBill = new ObservableCollection<UtilityModel>(receiveContext.Result);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error!", receiveContext.ErrorMessage, "OK");
            }
        }
        public ObservableCollection<UtilityModel> _UtiltiyBill;
        public ObservableCollection<UtilityModel> UtiltiyBill
        {
            get { return _UtiltiyBill; }
            set
            {
                _UtiltiyBill = value;
                OnPropertyChanged("UtiltiyBill");


            }
        }
        public ICommand SelectedItemCommand
        {
            get
            {
                return new Command<UtilityModel>((x) =>
                {
                    // CommonAttribute.SCInviceSelectedItem = x;
                    //  Navigation.PushAsync(new InvoiceDetailsPage());
                });
            }
        }
    }
}
