using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
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
        //private List<Produkt> mItems;
        private ListView mListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Oferta);
            Context context = this;

            #region Rest i ladowanie listy
            mListView = FindViewById<ListView>(Resource.Id.listaProdukt);
            #region /************ REST ****************
            /*
            REST lista = new REST(context);
            if (lista.listaP == null)
            {
                lista.listaP.Add(new Produkt());
                lista.listaP[0].Name = "brak elementow";
            }
            */
            #endregion//******************************

            #region testy
             //Do testow listy
               List<Produkt> mItems = new List<Produkt>();
               mItems.Add(new Produkt("koszulka", 2, "KOLOROWA", null));
               mItems.Add(new Produkt("glowa", 3, "Pusta", null));
               mItems.Add(new Produkt("glowa", 3, "Pusta", null));
               mItems.Add(new Produkt("glowa", 3, "Pusta", null));
               mItems.Add(new Produkt("glowa", 3, "Pusta", null));
               mItems.Add(new Produkt("glowa", 3, "Pusta", null));
               mItems.Add(new Produkt("glowa", 3, "Pusta", null));
               
            MyFirstViewAdapter adapter = new MyFirstViewAdapter(this, mItems, Resource.Layout.Oferta);
            #endregion
            //MyFirstViewAdapter adapter = new MyFirstViewAdapter(this, lista.listaP);
        
            mListView.Adapter = adapter;
            #endregion
           
           // mListView.ItemClick += delegate{adapter.przycisk_odkryj();};

           // adapter.mItems[0].Name

            // Create your application here
        }
        /*
        public void kliknij_okienko(object sender, EventArgs e)
        {
            FragmentTransaction tranzakcja = FragmentManager.BeginTransaction();
            
            SetContentView(Resource.Layout.Opcje_oferty);
            Okienko_oferty okienko = new Okienko_oferty();
            okienko.Show(tranzakcja, "komunikat");

            Spinner spinner = FindViewById<Spinner>(Resource.Id.Rozmiar);
            var rozmiar = new string[] { "M", "L", "XL", "XXL" };
            spinner.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, rozmiar);
        }*/

        /* Do testow listy */

    }
}