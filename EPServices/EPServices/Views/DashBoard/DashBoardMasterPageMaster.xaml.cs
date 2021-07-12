using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EPServices.ViewModels;
using EPServices.Views.Profile;
using EPServices.Views.PublicUser;
using EPServices.Views.YearlyServiceBill;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EPServices.Views.DashBoard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardMasterPageMaster : ContentPage
    {
        public ListView ListView;

        public DashBoardMasterPageMaster()
        {
            InitializeComponent();
            //Icon = PlatformImage.Resolver("menu.png");
            BindingContext = new DashBoardMasterPageMasterViewModel(Navigation);
            ListView = MenuItemsListView;
            IsBusy = false;

        }

        //class DashBoardMasterPageMasterViewModel : INotifyPropertyChanged
        //{
        //    public ObservableCollection<DashBoardMasterPageMenuItem> MenuItems { get; set; }

        //    public DashBoardMasterPageMasterViewModel()
        //    {
        //        MenuItems = new ObservableCollection<DashBoardMasterPageMenuItem>(new[]
        //        {
        //            new DashBoardMasterPageMenuItem { Id = 0, imgName="payment", Title = "Due Bill",TargetType=typeof(DueBillPage) },
        //            new DashBoardMasterPageMenuItem { Id = 1, imgName="history",Title = "Invoice History" ,TargetType=typeof(DueBillPage)},
        //             new DashBoardMasterPageMenuItem { Id = 3, imgName="account", Title = "easy Pay",TargetType=typeof(DueBillPage) },
        //               new DashBoardMasterPageMenuItem { Id = 4, imgName="history", Title = "easy Pay History",TargetType=typeof(DueBillPage) },
        //                new DashBoardMasterPageMenuItem { Id = 5, imgName="propertyicon", Title = "Find Property",TargetType=typeof(PropertiesHomePage) },
        //            new DashBoardMasterPageMenuItem { Id = 6, imgName="account",Title = "Transaction History" ,TargetType=typeof(DueBillPage)},
        //            new DashBoardMasterPageMenuItem { Id = 7, imgName="sr",Title = "Service Request" ,TargetType=typeof(DueBillPage)},
        //            new DashBoardMasterPageMenuItem { Id = 8, imgName="history",Title = "SR History" ,TargetType=typeof(DueBillPage)},
        //             new DashBoardMasterPageMenuItem { Id = 9,imgName="user", Title = "My Profile" ,TargetType=typeof(MyProfilePage) },
        //              new DashBoardMasterPageMenuItem { Id = 10,imgName="account", Title = "Change Password",TargetType=typeof(DueBillPage) },
        //               new DashBoardMasterPageMenuItem { Id = 11, imgName="call",Title = "Customer Care" ,TargetType=typeof(DueBillPage)},
        //               new DashBoardMasterPageMenuItem { Id = 12, imgName="logout",Title = "Logout"  },
        //        });
        //    }

        //    #region INotifyPropertyChanged Implementation
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //    {
        //        if (PropertyChanged == null)
        //            return;

        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //    #endregion
        //}

        void MenuItemsListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            DashBoardMasterPageMenuItem pageMenuItem = e.SelectedItem as DashBoardMasterPageMenuItem;
            if (pageMenuItem?.Title == "Logout")
                Application.Current.MainPage = new LoginPage();
        }
    }
}
