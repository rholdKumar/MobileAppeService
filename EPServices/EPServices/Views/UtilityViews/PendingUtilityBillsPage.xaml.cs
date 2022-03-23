using System;
using System.Collections.Generic;
using EPServices.Models;
using EPServices.ViewModels.UtilityViewModel;
using Xamarin.Forms;

namespace EPServices.Views.UtilityViews
{
    public partial class PendingUtilityBillsPage : ContentPage
    {
        public PendingUtilityBillsViewModel viewModel { get; set; }
        public PendingUtilityBillsPage()
        {
            InitializeComponent();
            BindingContext = viewModel= new PendingUtilityBillsViewModel(Navigation);
        }

        //void collectionList_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        //{
        //   // UtilityModel utility = e.CurrentSelection as UtilityModel;
        //   // viewModel.SelectedItemCommand(utility);
        //}
    }
}
