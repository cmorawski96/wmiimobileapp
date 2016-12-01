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
    class User
    {
        string imie { get; }
        string nawisko { get; }
        string nralbumu { get; }
        string kodkreskowy { get; }

        private User()
        {
            User user = new User();
        }
    }
}