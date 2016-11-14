using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace projekt
{
    [Activity(Label = "Panel_Menu")]
    public class Panel_Menu : Activity
    {
        Button button_oferta;
        Button button_koszyk;

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Panel_Menu);

            button_oferta = FindViewById<Button>(Resource.Id.button_oferta);
            button_oferta.Click += mButton_oferta;

            button_koszyk = FindViewById<Button>(Resource.Id.button_koszyk);
            button_koszyk.Click += mButton_koszyk;
            // Create your application here
        }
        void mButton_oferta(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Oferta));
            this.StartActivity(intent);
        }
        void mButton_koszyk(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Koszyk));
            this.StartActivity(intent);
        }
    }
}