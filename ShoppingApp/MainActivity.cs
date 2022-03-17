using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using static Google.Android.Material.BottomNavigation.BottomNavigationView;

namespace ShoppingApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnNavigationItemSelectedListener
    {
        private BottomNavigationView _bottomNavigationView;
        private DashboardFragment _dashboardFragment;
        private FavouriteFragment _favouriteFragment;
        private LocationFragment _locationFragment;
        private PersonFragment _personFragment;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            _bottomNavigationView = FindViewById<BottomNavigationView>(Resource.Id.bottomNavigationView);
            _bottomNavigationView.SetOnNavigationItemSelectedListener(this);
            _dashboardFragment = new DashboardFragment(this);
            _favouriteFragment = new FavouriteFragment();
            _locationFragment = new LocationFragment();
            _personFragment = new PersonFragment();
            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayout, _dashboardFragment).Commit();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch(item.ItemId)
            {
                case Resource.Id.home:

                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayout, _dashboardFragment).Commit();
                    break;
                case Resource.Id.favourite:

                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayout, _favouriteFragment).Commit();
                    break;
                case Resource.Id.location:

                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayout, _locationFragment).Commit();
                    break;
                case Resource.Id.person:

                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayout, _personFragment).Commit();
                    break;



            }

            return true;
        }
    }
}