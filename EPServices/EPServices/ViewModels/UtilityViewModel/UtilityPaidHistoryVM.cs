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
    public class UtilityPaidHistoryVM : BaseViewModel
    {
        public UtilityPaidHistoryVM(INavigation navigation) : base(navigation)
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
            ReceiveContext<List<UtilityModel>> receiveContext = await utilityManagementSL.UtilityPaidHistory();
            if (receiveContext.Status)
            {
                utilityModels = new ObservableCollection<UtilityModel>(receiveContext.Result);
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
                return new Command<UtilityModel>((x) => {
                    CommonAttribute.SelectedItem = x;
                    Navigation.PushAsync(new UtilityDetailsPage());
                });
            }
        }
        public ICommand SelectedItemCommand1
        {
            get
            {
                return new Command<int>(async (x) => {
                    int inid = x;

                });
            }
        }
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
