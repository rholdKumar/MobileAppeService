using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using EPServices.Models;
using EPServices.ServiceLayer;
using EPServices.Views.YearlyServiceBill;
using Xamarin.Forms;

namespace EPServices.ViewModels.YearlyServiceBill
{
    public class InvoiceHistoryViewModel:BaseViewModel
    {
        public InvoiceHistoryViewModel(INavigation navigation) : base(navigation)
        {
            Device.BeginInvokeOnMainThread(async () => {
               // await BindingData();
            });
            BillDetailsCommand = new Command<string>((res) => {
                string id = res;
                navigation.PushAsync(new InvoiceDetailsPage());
            });
        }
        public ICommand BillDetailsCommand { private set; get; }
        #region
        public async Task BindingData()
        {
            ServicesManagementSL userManagementSL = new ServicesManagementSL();
            ReceiveContext<List<Invoices>> receiveContext = await userManagementSL.InvoiceHistory(pid,year,wid);
            if (receiveContext.Status)
            {
                Invoices = new ObservableCollection<Invoices>(receiveContext.Result);
            }

        }
        #endregion
        int _pid;
        public int pid
        {
            get { return _pid; }
            set
            {
                _pid = value;
                OnPropertyChanged("pid");
            }
        }
        int _year;
        public int year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged("year");
            }
        }
        int _wid;
        public int wid
        {
            get { return _wid; }
            set
            {
                _wid = value;
                OnPropertyChanged("wid");
            }
        }
        ObservableCollection<Invoices> _Invoices;
        public ObservableCollection<Invoices> Invoices
        {
            get { return _Invoices; }
            set
            {
                _Invoices = value;
                OnPropertyChanged("Invoices");
            }
        }
    }
}
