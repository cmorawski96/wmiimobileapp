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
            mItems.Add(new Produkt("koszulka", 2, "KOLOROWA", "https://www.google.pl/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=0ahUKEwix5qj1ysTQAhWMFywKHdpDAAkQjRwIBw&url=http%3A%2F%2Fpics-about-space.com%2Fspacecraft-3d-android%3Fp%3D1&bvm=bv.139782543,d.bGg&psig=AFQjCNHWcnwQO1tlKsX3qULRmKEUgZT0AQ&ust=1480186597062625"));
            mItems.Add(new Produkt("glowa1", 3, "Pusta", null));
            mItems.Add(new Produkt("noga", 3, "Pusta", null));
            mItems.Add(new Produkt("szyja", 3, "Pusta", null));
            mItems.Add(new Produkt("pieta", 3, "Pusta", null));
            mItems.Add(new Produkt("lokiec", 3, "Pusta", null));
            mItems.Add(new Produkt("kark", 3, "Pusta", null));

            MyViewAdapter adapter = new MyViewAdapter(this, mItems, Resource.Layout.Oferta);

            #endregion
            //MyViewAdapter adapter = new MyViewAdapter(this, lista.listaP, Resource.Layout.Oferta);

            mListView.Adapter = adapter;
            #endregion


            // Create your application here
        }        
    }
}