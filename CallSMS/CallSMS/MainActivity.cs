using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace CallSMS
{
    [Activity(Label = "CallSMS", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button btnCall = FindViewById<Button>(Resource.Id.button1);
            btnCall.Click += delegate
             {
                 var uri1 = Android.Net.Uri.Parse("tel:6472042982");
                 var intent = new Intent(Intent.ActionDial, uri1);
                 StartActivity(intent);
             };
        }
    }
}

