using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace sevenindex.Views.onboarding
{
    public partial class MyPage_first : ContentPage
    {
        public MyPage_first()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(4), () =>
            {
                Navigation.PushModalAsync(new MyPage_lung());

                return false;
            });
        }
    }
}
