using System;
using System.ComponentModel;
using System.Threading.Tasks;
using EPServices.DependencyServices;
using Xamarin.Forms;

namespace EPServices.ViewModels
{
    public class BaseViewModel: INotifyPropertyChanged
    {
        
        public INavigation Navigation { get; set; }
        public BaseViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        public async Task DisplayAlert(string title,string msg)
        {
             await Application.Current.MainPage.DisplayAlert(title, msg, "Cancel");
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool _IsBusy;
        public bool IsBusy
        {
            get { return _IsBusy; }
            set
            {
                var hud = DependencyService.Get<IEPProgress>();
                if (value)
                {
                    hud.Show();
                }
                else
                {
                    hud.Dismiss();
                }
                _IsBusy = value;
                OnPropertyChanged("IsBusy");


            }
        }
    }
}
