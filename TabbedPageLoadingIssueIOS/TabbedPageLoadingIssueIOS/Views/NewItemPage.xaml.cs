using System;
using System.Collections.Generic;
using System.ComponentModel;
using TabbedPageLoadingIssueIOS.Models;
using TabbedPageLoadingIssueIOS.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageLoadingIssueIOS.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}