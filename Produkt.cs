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
    class Produkt
    {
        public string Nazwa { get; set; }
        public string Cena { get; set; }
        public string Opis { get; set; }
        public string Dostepne { get; set; }
        public ImageView ZdjProduktu { get; set; }
        


        public Produkt(string nazwa, string cena, string opis, string dostepne)
        {
            this.Nazwa = nazwa;
            this.Cena = cena;
            this.Opis = opis;
            this.Dostepne = dostepne;
            

        }
    }

    class MyFirstViewAdapter : BaseAdapter<Produkt>
    {
        public List<Produkt> mItems;
        private Context mContext;

        public MyFirstViewAdapter(Context context, List<Produkt> items)
        {
            mItems = items;
            mContext = context;
        }
        public override int Count
        {
            get { return mItems.Count; }
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override Produkt this[int position]
        {
            get { return mItems[position]; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListProdukt_Row, null, false);
            }

            TextView Nazwa = row.FindViewById<TextView>(Resource.Id.txtNazwa);
            Nazwa.Text = mItems[position].Nazwa;

            TextView Cena = row.FindViewById<TextView>(Resource.Id.txtCena);
            Cena.Text = mItems[position].Cena;

            TextView Opis = row.FindViewById<TextView>(Resource.Id.txtOpis);
            Opis.Text = mItems[position].Opis;

            TextView Dokladnosc = row.FindViewById<TextView>(Resource.Id.txtDokladnosc);
            Dokladnosc.Text = mItems[position].Dostepne;

            ImageView ZdjProduktu = row.FindViewById<ImageView>(Resource.Id.ImageProdukt);
            ZdjProduktu = mItems[position].ZdjProduktu;
            return row;
        }
    }
}