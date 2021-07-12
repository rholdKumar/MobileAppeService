using System;
using System.Collections.ObjectModel;
using EPServices.Views.DashBoard;
using EPServices.Views.Profile;
using EPServices.Views.PublicUser;
using EPServices.Views.YearlyServiceBill;
using Xamarin.Forms;

namespace EPServices.ViewModels
{
    public class DashBoardMasterPageMasterViewModel:BaseViewModel
    {
        public DashBoardMasterPageMasterViewModel(INavigation navigation) :base(navigation)
        {
            MenuItems = new ObservableCollection<DashBoardMasterPageMenuItem>(new[]
           {
                    new DashBoardMasterPageMenuItem { Id = 0, imgName="payment", Title = "Due Bill",TargetType=typeof(DueBillPage) },
                    new DashBoardMasterPageMenuItem { Id = 1, imgName="history",Title = "Invoice History" ,TargetType=typeof(InvoiceHistoryPage)},
                     new DashBoardMasterPageMenuItem { Id = 3, imgName="account", Title = "easy Pay",TargetType=typeof(DueBillPage) },
                       new DashBoardMasterPageMenuItem { Id = 4, imgName="history", Title = "easy Pay History",TargetType=typeof(DueBillPage) },
                        new DashBoardMasterPageMenuItem { Id = 5, imgName="propertyicon", Title = "Find Property",TargetType=typeof(PropertiesHomePage) },
                    new DashBoardMasterPageMenuItem { Id = 6, imgName="account",Title = "Transaction History" ,TargetType=typeof(DueBillPage)},
                    new DashBoardMasterPageMenuItem { Id = 7, imgName="sr",Title = "Service Request" ,TargetType=typeof(DueBillPage)},
                    new DashBoardMasterPageMenuItem { Id = 8, imgName="history",Title = "SR History" ,TargetType=typeof(DueBillPage)},
                     new DashBoardMasterPageMenuItem { Id = 9,imgName="user", Title = "My Profile" ,TargetType=typeof(MyProfilePage) },
                      new DashBoardMasterPageMenuItem { Id = 10,imgName="account", Title = "Change Password",TargetType=typeof(DueBillPage) },
                       new DashBoardMasterPageMenuItem { Id = 11, imgName="call",Title = "Customer Care" ,TargetType=typeof(DueBillPage)},
                       new DashBoardMasterPageMenuItem { Id = 12, imgName="logout",Title = "Logout"  },
                });
        }
        public ObservableCollection<DashBoardMasterPageMenuItem> MenuItems { get; set; }
        
    }
}
