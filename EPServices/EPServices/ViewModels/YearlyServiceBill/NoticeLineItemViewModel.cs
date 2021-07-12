using System;
using System.Threading.Tasks;
using EPServices.Models;
using EPServices.ServiceLayer;
using Xamarin.Forms;

namespace EPServices.ViewModels.YearlyServiceBill
{
    public class NoticeLineItemViewModel:BaseViewModel
    {
        public NoticeLineItemViewModel(INavigation navigation,int NID,int UID,string NGID) : base(navigation)
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
            ReceiveContext<ServiceChargesDetails> receiveContext = await userManagementSL.GetNoticeLineItems(nid,uid,NGID);
            if (receiveContext.Status)
            {
                ServiceChargesDetails = receiveContext.Result;
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
        ServiceChargesDetails _ServiceChargesDetails;
        public ServiceChargesDetails ServiceChargesDetails
        {
            get { return _ServiceChargesDetails; }
            set
            {
                _ServiceChargesDetails = value;
                OnPropertyChanged("ServiceChargesDetails");
            }
        }
    }
}
