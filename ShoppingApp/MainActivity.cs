using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomAppBar;
using Google.Android.Material.BottomNavigation;
using System;
using static Google.Android.Material.BottomNavigation.BottomNavigationView;

namespace ShoppingApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, AndroidX.AppCompat.Widget.Toolbar.IOnMenuItemClickListener
    {
        private TextView _textViewTitle;
        private ImageView _imageViewPhoto;
        private BottomAppBar _bottomAppBar;
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
            UIReferences();
            UISetClickListeneres();
            ObjectIntialization();
            MenuClickEnables();
            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayout, _dashboardFragment).Commit();
          
        }

        private void UIReferences()
        {
            _bottomAppBar = FindViewById<BottomAppBar>(Resource.Id.bottomAppBar);
           
        }

        private void UISetClickListeneres()
        {
            _bottomAppBar.SetOnMenuItemClickListener((AndroidX.AppCompat.Widget.Toolbar.IOnMenuItemClickListener)this);
        }

        private void ObjectIntialization()
        {
            _dashboardFragment = new DashboardFragment(this);
            _favouriteFragment = new FavouriteFragment();
            _locationFragment = new LocationFragment();
            _personFragment = new PersonFragment();
        }

        private void MenuClickEnables()
        {
            _bottomAppBar.Menu.GetItem(1).SetEnabled(false);
            _bottomAppBar.Menu.GetItem(3).SetEnabled(false);
            _bottomAppBar.Menu.GetItem(5).SetEnabled(false);
            _bottomAppBar.Menu.GetItem(7 ).SetEnabled(false);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        

        public bool OnMenuItemClick(IMenuItem item)
        {
            switch (item.ItemId)
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