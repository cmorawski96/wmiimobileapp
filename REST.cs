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
using RestSharp;



namespace projekt
{
    class REST
    {
        public List<Produkt> listaP = new List<Produkt>();

        public REST(Context context)
        {
            var client = new RestClient("http://sklepkortowiadawmii.azurewebsites.net");
            var request = new RestRequest("api/Products", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            try
            {
                List<Produkt> listProdukt = SimpleJson.DeserializeObject<List<Produkt>>(content);
                listaP.AddRange(listProdukt);
            }
            catch
            {
                AlertDialog.Builder builder = new AlertDialog.Builder(context);
                AlertDialog alertDialog = builder.Create();
                alertDialog.SetTitle("Problem z po³¹czeniem!!!");
                alertDialog.SetMessage("Problem z po³¹czeniem internetowym.");
                alertDialog.SetButton2("Ok", (s, ev) => { Toast.MakeText(context, "dziala", ToastLength.Long); });
                alertDialog.Show();
            }
        }

    }
}