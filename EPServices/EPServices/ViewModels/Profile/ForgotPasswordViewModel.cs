using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace EPServices.ViewModels.Profile
{
    public class ForgotPasswordViewModel:BaseViewModel
    {
        public ForgotPasswordViewModel(INavigation navigation) : base(navigation)
        {
            finalMsg = false;
            loginMsg = true;
            forgotPasswordCommand = new Command(() => {
                if (!finalMsg && loginMsg)
                {
                    loginMsg = false;
                    finalMsg = true;
                }
                else
                {
                    finalMsg = false;
                    loginMsg = true;
                }
                    
            });
            backtoLoginCommand = new Command(() => {

                Navigation.PopAsync();
            });
        }
        public ICommand forgotPasswordCommand { private set; get; }
        public ICommand backtoLoginCommand { private set; get; }
        bool _finalMsg;
        public bool finalMsg
        {
            get { return _finalMsg; }
            set
            {
                _finalMsg = value;
                OnPropertyChanged("finalMsg");
            }
        }
        bool _loginMsg;
        public bool loginMsg
        {
            get { return _loginMsg; }
            set
            {
                _loginMsg = value;
                OnPropertyChanged("loginMsg");
            }
        }
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
    }
}
