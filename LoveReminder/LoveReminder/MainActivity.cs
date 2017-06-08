using Android.App;
using Android.Widget;
using Android.OS;

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
            Button button = FindViewById<Button>(Resource.Id.ReminderButton);
            button.Click +=
                delegate { textView.Text = "It Works!"; };
        }
    }
}

