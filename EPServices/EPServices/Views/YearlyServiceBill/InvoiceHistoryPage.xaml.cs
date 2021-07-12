using System;
using System.Collections.Generic;
using EPServices.ViewModels.YearlyServiceBill;
using Xamarin.Forms;

namespace EPServices.Views.YearlyServiceBill
{
    public partial class InvoiceHistoryPage : ContentPage
    {
        public InvoiceHistoryPage()
        {
            InitializeComponent();
            BindingContext = new InvoiceHistoryViewModel(Navigation);
        }
    }
}
