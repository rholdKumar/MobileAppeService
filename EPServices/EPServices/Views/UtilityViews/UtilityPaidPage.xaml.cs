using System;
using System.Collections.Generic;
using EPServices.ViewModels.UtilityViewModel;
using Xamarin.Forms;

namespace EPServices.Views.UtilityViews
{
    public partial class UtilityPaidPage : ContentPage
    {
        public UtilityPaidPage()
        {
            InitializeComponent();
            BindingContext = new UtilityPaidHistoryVM(Navigation);
        }
    }
}
