using System;
using System.Collections.Generic;
using EPServices.ViewModels.YearlyServiceBill;
using Xamarin.Forms;

namespace EPServices.Views.YearlyServiceBill
{
    public partial class InvoiceDetailsPage : ContentPage
    {
        public InvoiceDetailsPage()
        {
            InitializeComponent();
            BindingContext = new InvoiceDetailsViewModel(Navigation);
        }
    }
}
