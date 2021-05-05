using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using sevenindex.Views.menu;
using sevenindex.Views.onboarding;
namespace sevenindex
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyPage_login_student();
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
