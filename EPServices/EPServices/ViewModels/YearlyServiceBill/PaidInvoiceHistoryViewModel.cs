using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using EPServices.Models;
using EPServices.ServiceLayer;
using Xamarin.Forms;

namespace EPServices.ViewModels.YearlyServiceBill
{
    public class PaidInvoiceHistoryViewModel:BaseViewModel
    {
        public PaidInvoiceHistoryViewModel(INavigation navigation, int NID, int UID, string NGID) : base(navigation)
        {
            nid = NID;
            uid = UID;
            this.NGID = NGID;
            Device.BeginInvokeOnMainThread(async () => {
                await BindingData();
            });
        }
        #region
        public async Task BindingData()
        {
            ServicesManagementSL userManagementSL = new ServicesManagementSL();
            ReceiveContext<List<Invoices>> receiveContext = await userManagementSL.GetPaidInvoiceHistory(nid, uid, NGID);
            if (receiveContext.Status)
            {
                Invoices = new ObservableCollection<Invoices>(receiveContext.Result);
            }

        }
        #endregion
        int _nid;
        public int nid
        {
            get { return _nid; }
            set
            {
                _nid = value;
                OnPropertyChanged("nid");
            }
        }
        int _uid;
        public int uid
        {
            get { return _uid; }
            set
            {
                _uid = value;
                OnPropertyChanged("uid");
            }
        }
        string _NGID;
        public string NGID
        {
            get { return _NGID; }
            set
            {
                _NGID = value;
                OnPropertyChanged("NGID");
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
