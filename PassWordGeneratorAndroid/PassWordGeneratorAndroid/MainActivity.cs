using Android.App;
using Android.Widget;
using Android.OS;

namespace PassWordGeneratorAndroid
{
    [Activity(Label = "PassWordGeneratorAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            EditText salt = FindViewById<EditText>(Resource.Id.baseWord);
            TextView password = FindViewById<TextView>(Resource.Id.passwordView);
            Button generate = FindViewById<Button>(Resource.Id.confirmButton);

            generate.Click += (sender, e) =>
            {
                string pass = PassWordGeneratorAndroid.Generator.generatePass(salt.Text);
                password.Text = pass;
            };
        }
    }
}

