using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Collections.ObjectModel;
using Android.Provider;
using Android.Net;
using static Android.Resource;
using LoveReminder.Utility;

namespace LoveReminder
{
    [Activity(Label = "LoveReminder", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);
            TextView textView = FindViewById < TextView>(Resource.Id.LoveQuoteTextView);
            ImageView imageView = FindViewById<ImageView>(Resource.Id.LoveReminderImageView);
            Button button = FindViewById<Button>(Resource.Id.ReminderButton);

            button.Click += delegate {
                textView.Text = "It Works!";
                //var imageIntent = new Intent();
                //imageIntent.SetType("image/*");
                //imageIntent.SetAction(Intent.);
                //Uri image = MediaStore.Images.Media.ExternalContentUri;
                var imageBitmap = ImageHelper.GetImageBitmapFromUrl("https://scontent-dft4-2.xx.fbcdn.net/v/t1.0-9/16939139_10154989976651192_2807782103431374592_n.jpg?oh=049b4bc179e4a774b62642dcd5df42c4&oe=59E76E32");

                //
                imageView.SetImageBitmap(imageBitmap);
            }; 
        }
    }
}

