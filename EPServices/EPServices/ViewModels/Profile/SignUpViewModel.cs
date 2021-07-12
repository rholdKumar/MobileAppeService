using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace EPServices.ViewModels.Profile
{
    public class SignUpViewModel:BaseViewModel
    {
        public SignUpViewModel(INavigation navigation) : base(navigation)
        {
            backtoLoginCommand = new Command(() => {

                Navigation.PopAsync();
            });
            uploadCommand = new Command(() => {
               
            });
        }
        public ICommand backtoLoginCommand { private set; get; }
        public ICommand uploadCommand { private set; get; }

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
