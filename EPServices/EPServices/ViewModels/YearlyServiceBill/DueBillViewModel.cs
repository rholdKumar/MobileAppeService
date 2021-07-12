using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using EPServices.Hepler;
using EPServices.Models;
using EPServices.ServiceLayer;
using EPServices.Views.YearlyServiceBill;
using Xamarin.Forms;

namespace EPServices.ViewModels.YearlyServiceBill
{
    public class DueBillViewModel:BaseViewModel
    {
        public DueBillViewModel(INavigation navigation) : base(navigation)
        {
            Device.BeginInvokeOnMainThread(async () => {
               // await BindingData();
            });
            BillDetailsCommand = new Command<string>( (res) => {
                string id = res;
                navigation.PushAsync(new BillDetailsPage());
            });
        }
        //BillDetailsCommand
        public ICommand BillDetailsCommand { private set; get; }
        #region
        public async Task BindingData()
        {
            ServicesManagementSL userManagementSL = new ServicesManagementSL();
            ReceiveContext<List<NoticeInfoModel>> receiveContext = await userManagementSL.GetDueBills(CommonAttribute.mOwnerData.ownerDetails.OwnerID);
            if (receiveContext.Status)
            {
                NoticeInfoModels =new ObservableCollection<NoticeInfoModel>(receiveContext.Result);
            }
            
        }
        #endregion

        public ObservableCollection<NoticeInfoModel> _NoticeInfoModels;
        public ObservableCollection<NoticeInfoModel> NoticeInfoModels
        {
            get { return _NoticeInfoModels; }
            set
            {
                _NoticeInfoModels = value;
                OnPropertyChanged("NoticeInfoModels");

            }
        }
    }
}
