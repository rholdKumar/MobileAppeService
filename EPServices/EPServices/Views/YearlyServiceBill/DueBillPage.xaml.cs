using System;
using System.Collections.Generic;
using EPServices.ViewModels.YearlyServiceBill;
using Xamarin.Forms;

namespace EPServices.Views.YearlyServiceBill
{
    public partial class DueBillPage : ContentPage
    {
        public DueBillPage()
        {
            InitializeComponent();
            BindingContext = new DueBillViewModel(Navigation);
        }
    }
}
