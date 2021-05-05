using System;
using System.Collections.Generic;
using sevenindex.Models;

using Xamarin.Forms;

namespace sevenindex.Views.onboarding
{
    public partial class MyPage_parties : ContentPage
    {
        public MyPage_parties()
        {
            InitializeComponent();

            if (constants.arabe == 1)
            {
                txtprof.Text = "أستاد";
                txtstudent.Text = "تلميذ";
                txtuser.Text = "المستعمل";
            }
            if (constants.france == 1)
            {
                txtprof.Text = "professeur";
                txtstudent.Text = "élève";
                txtuser.Text = "utilisateur";
            }


            var n1 = new TapGestureRecognizer();
            n1.Tapped += btn1_click;
            frm1.GestureRecognizers.Add(n1);


            var n2 = new TapGestureRecognizer();
            n2.Tapped += btn2_click;
            frm2.GestureRecognizers.Add(n2);


            var n3 = new TapGestureRecognizer();
            n3.Tapped += btn3_click;
            frm3.GestureRecognizers.Add(n3);

        }

        private async void btn1_click(object sender,EventArgs e)
        {
           // await Navigation.PushModalAsync(new ,false);
        }

        private async void btn2_click(object sender,EventArgs e)
        {
            //await Navigation.PushModalAsync(new ,false);
        }

        private async void btn3_click(object sender,EventArgs e)
        {
           // await Navigation.PushModalAsync(new, false);
        }

    }
}
