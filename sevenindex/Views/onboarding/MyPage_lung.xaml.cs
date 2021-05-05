using System;
using System.Collections.Generic;
using sevenindex.Models;
using Xamarin.Forms;

namespace sevenindex.Views.onboarding
{
    public partial class MyPage_lung : ContentPage
    {
        public MyPage_lung()
        {
            InitializeComponent();

            constants.arabe = 1;
            constants.france = 0;


            var n1 = new TapGestureRecognizer();
            n1.Tapped += btn_changertextarabe;
            frmarabe.GestureRecognizers.Add(n1);

            var n2 = new TapGestureRecognizer();
            n2.Tapped += btn_changertextfrance;
            frmfrance.GestureRecognizers.Add(n2);


            btnsuivant.Clicked += (s,e) =>
            {
                Navigation.PushModalAsync(new MyPage_parties());
            };

        }

        private void btn_changertextarabe(object sender,EventArgs e)
        {
            btnsuivant.Text = "التالي";
            francetxt.Text = "الفرنسية";
            arabetxt.Text = "العربية";
            txtlang.Text = "المرجو إختيار اللغة";
            constants.arabe = 1;
            constants.france = 0;
        }

        private void btn_changertextfrance(object sender,EventArgs e)
        {
            btnsuivant.Text = "Suivant";

            arabetxt.Text = "Arabe";
            francetxt.Text = "France"; 
            txtlang.Text = "Veuillez choisir la langue";
            constants.arabe = 0;
            constants.france = 1;
         }
    }
}
