using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using EPServices.Models;
using EPServices.ServiceLayer;
using EPServices.Views.PublicUser;
using Xamarin.Forms;

namespace EPServices.ViewModels.PublicUserViewModel
{
    public class UnitListViewModel : BaseViewModel
    {
        public UnitListViewModel(INavigation navigation, int pid) : base(navigation)
        {
            this.pid = pid;
            Device.BeginInvokeOnMainThread(async () => {
                await BindingData();
            });
        }
        public int pid { get; set; }
        public async Task BindingData()
        {
            UserManagementSL userManagementSL = new UserManagementSL();
            ReceiveContext<List<UnitModel>> receiveContext = await userManagementSL.GetUnitList(pid);
            if (receiveContext.Status)
            {
                Properties = new ObservableCollection<UnitModel>(receiveContext.Result);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error!", receiveContext.ErrorMessage, "OK");
            }
        }
        public ObservableCollection<UnitModel> _Properties;
        public ObservableCollection<UnitModel> Properties
        {
            get { return _Properties; }
            set
            {
                _Properties = value;
                OnPropertyChanged("Properties");


            }
        }
        public ICommand SelectedItemCommand
        {
            get
            {
                return new Command<UnitModel>((x) =>
                {
                    // CommonAttribute.SCInviceSelectedItem = x;
                      Navigation.PushAsync(new UtilityBillsPage(x.PTID,x.UID));
                });
            }
        }
    }
}
