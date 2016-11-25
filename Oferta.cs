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
        private List<Produkt> mItems;
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
               mItems = new List<Produkt>();
               mItems.Add(new Produkt("koszulka", 2, "KOLOROWA", null));
               mItems.Add(new Produkt("glowa1", 3, "Pusta", null));
               mItems.Add(new Produkt("glowa2", 3, "Pusta", null));
               mItems.Add(new Produkt("glowa3", 3, "Pusta", null));
               mItems.Add(new Produkt("glowa4", 3, "Pusta", null));
               mItems.Add(new Produkt("glowa5", 3, "Pusta", null));
               mItems.Add(new Produkt("glowa6", 3, "Pusta", null));
               
            MyViewAdapter adapter = new MyViewAdapter(this, mItems, Resource.Layout.Oferta);
            #endregion
            //MyViewAdapter adapter = new MyViewAdapter(this, lista.listaP);
        
            mListView.Adapter = adapter;
            #endregion
            
           //mListView.ItemClick += kliknij_okienko;
           // mListView.Click += delegate { kliknij_okienko; };
            // Create your application here
        }
        
        public void kliknij_okienko(object sender, AdapterView.ItemClickEventArgs e)
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            AlertDialog alertDialog = builder.Create();
            alertDialog.SetTitle("Czy chcesz dodaæ produkt do koszyka?");
            alertDialog.SetMessage(mItems[e.Position].Name + "\nCena: " + mItems[e.Position].Price);
            alertDialog.SetButton2("Tak", (s, ev) => { Kosz.lista.Add(mItems[e.Position]); alertDialog.Cancel(); });
            alertDialog.SetButton("Nie", (s, ev) => { alertDialog.Cancel(); });
            alertDialog.Show();
        }
        /* Do testow listy */

    }
}