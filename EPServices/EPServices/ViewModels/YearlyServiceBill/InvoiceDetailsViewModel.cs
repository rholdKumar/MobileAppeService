using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace EPServices.ViewModels.YearlyServiceBill
{
    public class InvoiceDetailsViewModel:BaseViewModel
    {
        public InvoiceDetailsViewModel(INavigation navigation) : base(navigation)
        {
            isServiceDetails = false;
            isPaidAmounts = false;
            OpenServiceDetailsCommand = new Command(() => {
                if (isServiceDetails)
                    isServiceDetails = false;
                else
                    isServiceDetails = true;


            });
            PaidAmountCommand = new Command(() => {
                if (isPaidAmounts)
                    isPaidAmounts = false;
                else
                    isPaidAmounts = true;
            });
        }
        public ICommand OpenServiceDetailsCommand { private set; get; }
        public ICommand PaidAmountCommand { private set; get; }
        public bool _isServiceDetails;
        public bool isServiceDetails
        {
            get { return _isServiceDetails; }
            set
            {
                _isServiceDetails = value;
                OnPropertyChanged("isServiceDetails");

            }
        }
        public bool _isPaidAmounts;
        public bool isPaidAmounts
        {
            get { return _isPaidAmounts; }
            set
            {
                _isPaidAmounts = value;
                OnPropertyChanged("isPaidAmounts");

            }
        }
    }
}
