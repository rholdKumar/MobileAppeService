using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using EPServices.Hepler;
using EPServices.Models;
using EPServices.ServiceLayer;
using EPServices.Views.DashBoard;
using EPServices.Views.Profile;
using Xamarin.Forms;

namespace EPServices.ViewModels.Profile
{
    public class LoginViewModel: BaseViewModel
    {  
        public LoginViewModel(INavigation navigation) :base(navigation)
        {
            #if DEBUG
            Email = "adabalakumar9@gmail.com";
            Password = "123456";
            #endif
            userAuthCommand = new Command(async () => { await userAuth(); });
            signUpCommand = new Command(() => {
                Navigation.PushAsync(new SignUpPage());
            });
            forgotPasswordCommand = new Command( () => {
                Navigation.PushAsync(new ForgotPasswordPage());
            });
        }
        public ICommand userAuthCommand { private set; get; }
        public ICommand forgotPasswordCommand { private set; get; }
        public ICommand signUpCommand { private set; get; }
        #region Method
        public async Task userAuth()
        {
           // await DisplayAlert("", "Please enter email id!");
            
            if (await Validation())
            {
                IsBusy = true;
                //UserManagementSL userManagementSL = new UserManagementSL();
                //ReceiveContext<mOwnerData> receiveContext = await userManagementSL.ValidateUser(Email, DataHelper.Encrypt(Password));
                //if (receiveContext != null && receiveContext.Status)
                //{
                //    CommonAttribute.mOwnerData = receiveContext.Result;
                   Application.Current.MainPage = new DashBoardMasterPage();
                //}
                //else
                //{
                //    await Application.Current.MainPage.DisplayAlert("Error!", receiveContext?.ErrorMessage, "OK");
                //}
                
               
            }
        }
        public async Task<bool> Validation()
        {
            if (string.IsNullOrEmpty(Email)){

                await Application.Current.MainPage.DisplayAlert("", "Please enter email id!", "OK");
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("", "Please enter password!", "OK");
                return false;
            }
            return true;
        }
        #endregion
        #region properties
        //ObservableCollection<PropertyInfoModel> properties;
        //public ObservableCollection<PropertyInfoModel> Properties
        //{
        //    get { return properties; }
        //    set
        //    {
        //        properties = value;
        //        OnPropertyChanged("Properties");
        //    }
        //}
        string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
        string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        #endregion

    }
}
