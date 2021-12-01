using System.ComponentModel;
using TabbedPageLoadingIssueIOS.ViewModels;
using Xamarin.Forms;

namespace TabbedPageLoadingIssueIOS.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}