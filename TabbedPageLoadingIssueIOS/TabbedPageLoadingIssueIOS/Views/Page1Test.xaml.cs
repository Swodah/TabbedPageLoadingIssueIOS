using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPageLoadingIssueIOS.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageLoadingIssueIOS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1Test : ContentPage
    {
        public Page1Test()
        {
            InitializeComponent();

        }
        public BaseViewModel ViewModel => this.BindingContext as BaseViewModel;

    }
}