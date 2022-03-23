using System;
using System.Collections.Generic;
using EPServices.ViewModels.UtilityViewModel;
using Xamarin.Forms;

namespace EPServices.Views.UtilityViews
{
    public partial class UtilityDetailsPage : ContentPage
    {
        public UtilityDetailsPage()
        {
            try
            {
                InitializeComponent();
                BindingContext = new UtilityDetailsViewModel(Navigation);
                //	InnerException	{System.NullReferenceException: Object reference not set to an instance of an object   at EPServices.ViewModels.UtilityViewModel.UtilityDetailsViewModel.get_PaymentStatus () [0x00001] in /Users/mac/Documents/Projects/EPServices/EPServices/ViewModels/UtilityView…}	
            }
            catch (Exception ex)
            {

            }
        }
    }
}
