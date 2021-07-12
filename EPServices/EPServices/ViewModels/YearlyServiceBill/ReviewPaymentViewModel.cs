using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EPServices.Hepler;
using EPServices.Models;
using EPServices.ServiceLayer;
using Xamarin.Forms;

namespace EPServices.ViewModels.YearlyServiceBill
{
    public class ReviewPaymentViewModel:BaseViewModel
    {
        public ReviewPaymentViewModel(INavigation navigation) : base(navigation)
        {
            Device.BeginInvokeOnMainThread(async () => {
                await BindingData();
            });
        }
        #region
        public async Task BindingData()
        {
            ServicesManagementSL userManagementSL = new ServicesManagementSL();
            ReceiveContext<ServiceChargesDetails> receiveContext = await userManagementSL.GetReviewPayment(CommonAttribute.mOwnerData.ownerDetails.OwnerID);
            if (receiveContext.Status)
            {
                ServiceChargesDetails = receiveContext.Result;
            }

        }
        public async Task PostPaymentRequest(PaymentRequestModel RequestModel)
        {
            ServicesManagementSL userManagementSL = new ServicesManagementSL();
            ReceiveContext<string> receiveContext = await userManagementSL.PostPaymentRequest(RequestModel);
            if (receiveContext.Status)
            {
               
            }

        }
        #endregion
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
