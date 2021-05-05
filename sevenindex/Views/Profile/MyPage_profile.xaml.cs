using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace sevenindex.Views.Profile
{
    public partial class MyPage_profile : ContentPage
    {
        public MyPage_profile()
        {
            InitializeComponent();

            var n1 = new TapGestureRecognizer();
            n1.Tapped += (s,e) =>
            {
                Navigation.PushModalAsync(new MyPage_datapro());
            };
            frm1.GestureRecognizers.Add(n1);

            var n2 = new TapGestureRecognizer();
            n2.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new MyPage_conf());
            };
            frm2.GestureRecognizers.Add(n2);

            var n3 = new TapGestureRecognizer();
            n3.Tapped += (s, e) =>
            {
              //  Navigation.PushModalAsync(new m);
            };
            frm3.GestureRecognizers.Add(n3);
            
        }
    }
}
