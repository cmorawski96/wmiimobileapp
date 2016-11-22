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
    [Activity(Label = "Koszyk")]
    public class Koszyk : Activity
    {
        private ListView mListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Koszyk);
            Context context = this;
            mListView = FindViewById<ListView>(Resource.Id.kosz_listview);
            MyFirstViewAdapter adapter = new MyFirstViewAdapter(this, Kosz.lista, Resource.Layout.Koszyk);
            mListView.Adapter = adapter;
            #region cos
            /*
            TextView kosz_1 = FindViewById<TextView>(Resource.Id.kosz_name);
            if(Kosz.czy_pusty())
            {
                kosz_1.Text = Kosz.return_name(0);
            }
            else
            {
                kosz_1.Text = "pusto";
            }
            */
            #endregion
            // Create your application here
        }
    }

    public static class Kosz
    {
        public static List<Produkt> lista = new List<Produkt>();
        public static void Add_produkt(Produkt produkt)
        {
            lista.Add(produkt);
        }
        public static bool czy_pusty()
        {
            if (lista.Count != 0)
                return true;
            else
                return false;
        }
        public static string return_name(int position)
        {
            return lista[position].Name;
        }
             
    }
}