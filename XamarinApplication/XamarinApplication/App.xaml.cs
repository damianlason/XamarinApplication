using System;
using XamarinApplication.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RootTabbedPage();
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
