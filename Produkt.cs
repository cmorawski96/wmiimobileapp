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
using Android.Graphics;
using System.Net;
using Android.Transitions;

namespace projekt
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
    }

    /* test produkt
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
    */
    class MyFirstViewAdapter : BaseAdapter<Produkt>
    {
        public List<Produkt> mItems;
        private Context mContext;
        public View row;
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
            row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListProdukt_Row, null, false);
            }

            Set_Text(mItems[position].Name, row.FindViewById<TextView>(Resource.Id.txtNazwa));
            Set_Text(mItems[position].Price, row.FindViewById<TextView>(Resource.Id.txtCena));
            Set_Text(mItems[position].Description, row.FindViewById<TextView>(Resource.Id.txtOpis));
            Set_Text(mItems[position].PictureUrl, row.FindViewById<TextView>(Resource.Id.txtDokladnosc));
            Set_Image(mItems[position].PictureUrl, row.FindViewById<ImageView>(Resource.Id.ImageProdukt));

            return row;
        }
        protected void Set_Text(object text, TextView textview)
        {
            textview.Text = Convert.ToString(text); 
        }
        protected void Set_Image(string url, ImageView imageview)
        {
            if(url != null)
            {
                Bitmap imageBitmap = null;
                using (var webClient = new WebClient())
                {
                    var imageBytes = webClient.DownloadData(url);
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);  
                        imageview.SetImageBitmap(imageBitmap);
                    }
                }
            }
        }
    }
}