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
    [Activity(Label = "Oferta")]
    public class Oferta : Activity
    {
        private List<Produkt> mItems;
        private ListView mListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Oferta);
            mListView = FindViewById<ListView>(Resource.Id.listaProdukt);

            mItems = new List<Produkt>();
            AddProdukt("koszulka", "2.50", "KOLOROWA", "tak");
            AddProdukt("glowa", "3.20", "Pusta", "nie");

            MyFirstViewAdapter adapter = new MyFirstViewAdapter(this, mItems);
            mListView.Adapter = adapter;
            
            // Create your application here
        }
        void AddProdukt(string nazwa, string cena, string opis, string dostepne)
        {
            mItems.Add(new Produkt(nazwa, cena, opis, dostepne));
        }
    }
}