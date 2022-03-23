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
    public class PropertyListViewModel: BaseViewModel
    {
        public PropertyListViewModel(INavigation navigation) : base(navigation)
        {
            Device.BeginInvokeOnMainThread(async () => {
                  await BindingData();
            });
        }
        public async Task BindingData()
        {
            UserManagementSL userManagementSL = new UserManagementSL();
            ReceiveContext<List<PropertyModel>> receiveContext = await userManagementSL.GetPropertiesList();
            if (receiveContext.Status)
            {
                Properties =new ObservableCollection<PropertyModel>(receiveContext.Result);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error!", receiveContext.ErrorMessage, "OK");
            }
        }
        public ObservableCollection<PropertyModel> _Properties;
        public ObservableCollection<PropertyModel> Properties
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
                return new Command<PropertyModel>((x) =>
                {
                   // CommonAttribute.SCInviceSelectedItem = x;
                    Navigation.PushAsync(new UnitListPage(x.PTID));
                });
            }
        }
    }
}
