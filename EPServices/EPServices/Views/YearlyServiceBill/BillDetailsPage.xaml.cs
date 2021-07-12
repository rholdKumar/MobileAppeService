using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EPServices.Views.YearlyServiceBill
{
    public partial class BillDetailsPage : ContentPage
    {
        public BillDetailsPage()
        {
            InitializeComponent();
            //servicecharge
        }

        void SegControl_ValueChanged(System.Object sender, SegmentedControl.FormsPlugin.Abstractions.ValueChangedEventArgs e)
        {
            lblFullAmount.IsVisible = false;
            lblminAmount.IsVisible = false;
            txtOtherAmount.IsVisible = false;
            if (SegControl.SelectedSegment == 0)
                lblFullAmount.IsVisible = true;
            else if (SegControl.SelectedSegment == 1)
                lblminAmount.IsVisible = true;
            else if (SegControl.SelectedSegment == 2)
                txtOtherAmount.IsVisible = true;

        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new InvoiceDetailsPage());
        }
    }
}
