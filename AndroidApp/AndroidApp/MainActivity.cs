using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Com.Shield.Android;
using Org.Json;

namespace AndroidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource

            var obj = new Shield.Builder(this, "dda05c5ddac400e1c133a360e2714aada4cda052", "9ce44f88a25272b6d9cbb430ebbcfcf1")
                .SetLogLevel(Shield.LogLevel.Debug)
                .SetEnvironment(Shield.EnvironmentProd)
                .RegisterDeviceShieldCallback(new MyShieldCallback<JSONObject>())
                .Build();

            Shield.SetSingletonInstance(obj);


            Task.Run(async () =>
            {
                await Task.Delay(2000);

                var sessionID = obj.SessionId;
                System.Console.WriteLine("SessionID==" + sessionID);

                System.Console.WriteLine("LatestDeviceResult==" + obj.LatestDeviceResult);

            });


            SetContentView(Resource.Layout.activity_main);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public class MyShieldCallback<T> : Java.Lang.Object, IShieldCallback
        {
            public void OnSuccess(Java.Lang.Object data)
            {
                // Handle the success case
                System.Console.WriteLine("Akash Success Callback==" + data);
            }

            public void OnFailure(ShieldException e)
            {
                // Handle the failure case
                e?.PrintStackTrace();
            }
        }
    }
}
