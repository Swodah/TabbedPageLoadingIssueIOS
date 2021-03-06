using System;
using TabbedPageLoadingIssueIOS.Services;
using TabbedPageLoadingIssueIOS.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageLoadingIssueIOS
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new TabbedTestPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
