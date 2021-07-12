using System;
using System.Threading.Tasks;
using System.Windows.Input;
using EPServices.Hepler;
using EPServices.Models;
using EPServices.ServiceLayer;
using EPServices.Views.YearlyServiceBill;
using Xamarin.Forms;

namespace EPServices.ViewModels
{
    public class DashBoardViewModel:BaseViewModel
    {
        public DashBoardViewModel(INavigation navigation) : base(navigation)
        {
            Device.BeginInvokeOnMainThread(async () => {
              //  await BindingData();
            });
            DueBillCommand = new Command(() => { Navigation.PushAsync(new DueBillPage()); });
            InvoiceHistoryCommand = new Command(() => { Navigation.PushAsync(new InvoiceHistoryPage()); });
        }
        #region
        public async Task BindingData()
        {
            UserManagementSL userManagementSL = new UserManagementSL();
            ReceiveContext<mUserDashBoadModel> receiveContext = await userManagementSL.GetOwnerDashBoard(CommonAttribute.mOwnerData.ownerDetails.OwnerID);
            if (receiveContext.Status)
            {
                mUserDashBoadModel = receiveContext.Result;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error!", receiveContext.ErrorMessage, "OK");
            }
        }
        #endregion
        //InvoiceHistoryPage
        public ICommand DueBillCommand { private set; get; }
        public ICommand InvoiceHistoryCommand { private set; get; }

        public string _Email;
        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                OnPropertyChanged("Email");


            }
        }
        public string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                OnPropertyChanged("Password");

            }
        }
        public mUserDashBoadModel _mUserDashBoadModel;
        public mUserDashBoadModel mUserDashBoadModel
        {
            get { return _mUserDashBoadModel; }
            set
            {
                _mUserDashBoadModel = value;
                OnPropertyChanged("mUserDashBoadModel");

            }
        }
        
    }
}
