using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPageLoadingIssueIOS.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageLoadingIssueIOS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedTestPage : TabbedPage
    {
        public TabbedTestPage()
        {
            InitializeComponent();
            this.BindingContext = new BaseViewModel();
        }
        public BaseViewModel ViewModel => this.BindingContext as BaseViewModel;
        protected override async void OnAppearing()
        {
            base.OnAppearing();


            await this.ViewModel.Initialize();

            this.ViewModel.Initialize().Wait();
            // New way of handling how pages are shown
            if (this.ViewModel.Pages.Count !=0)
            {
                foreach (var page in this.ViewModel.Pages)
                {
                    Page newPage;
                    newPage = page;

                    this.Children.Add(newPage);
                }
            }
        }
    }
}