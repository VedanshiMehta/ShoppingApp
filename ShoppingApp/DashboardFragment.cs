using Fragment = AndroidX.Fragment.App.Fragment;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.RecyclerView.Widget;

namespace ShoppingApp
{
    public class DashboardFragment : Fragment
    {
        private Context context;
        private RecyclerView _recyclerViewDailySpends;
        private RecyclerView _recyclerViewWishlist;
        private RecyclerView.LayoutManager _layoutManagerDailySpends;
        private RecyclerView.LayoutManager _layoutManagerWishlist;
        private AdapterDailySpends _adapterDailySpends;
        private AdapterWishlists _adapterWishlists;
        private DailySpends _dailySpends;
        private Wishlists _wishlists;

        public DashboardFragment(Context context)
        {
            this.context = context;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            View view = inflater.Inflate(Resource.Layout.dashboardFragmentLayout, container, false);

            _recyclerViewDailySpends = view.FindViewById<RecyclerView>(Resource.Id.recyclerViewDailySpends);
       

            _layoutManagerDailySpends = new LinearLayoutManager(context);
            _recyclerViewDailySpends.SetLayoutManager(_layoutManagerDailySpends);

            _dailySpends = new DailySpends();

            _adapterDailySpends = new AdapterDailySpends(this,_dailySpends);
            _recyclerViewDailySpends.SetAdapter(_adapterDailySpends);


            _recyclerViewWishlist = view.FindViewById<RecyclerView>(Resource.Id.recyclerViewWishList);

            _layoutManagerWishlist = new GridLayoutManager(context,1 ,GridLayoutManager.Horizontal, true);
            _recyclerViewWishlist.SetLayoutManager(_layoutManagerWishlist);

            _wishlists = new Wishlists();

            _adapterWishlists = new AdapterWishlists(context, _wishlists);
            _recyclerViewWishlist.SetAdapter(_adapterWishlists);


            return view;
        }
    }
}