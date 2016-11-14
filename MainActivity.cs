using Android.App;
using Android.Widget;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projekt
{
    [Activity(Label = "projekt", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button zaloguj = FindViewById<Button>(Resource.Id.zaloguj);

            zaloguj.Click += mButton_zaloguj;
        }

        void mButton_zaloguj(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Panel_Menu));
            this.StartActivity(intent);
            this.Finish();
        }
    }
}

