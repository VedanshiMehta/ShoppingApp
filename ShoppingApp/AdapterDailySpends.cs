using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp
{
    class AdapterDailySpends : RecyclerView.Adapter
    {
        private DashboardFragment dashboardFragment;
        private DailySpends dailySpends;

        public AdapterDailySpends(DashboardFragment dashboardFragment, DailySpends dailySpends)
        {
            this.dashboardFragment = dashboardFragment;
            this.dailySpends = dailySpends;
        }

        public override int ItemCount => dailySpends.SpendNumbers;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ViewHolderDailySpends _viewHolderDailySpends = holder as ViewHolderDailySpends;
            _viewHolderDailySpends.BindData(dailySpends[position]);
            if (position == 0)
            {
                _viewHolderDailySpends._dailySpendImageView.SetBackgroundResource(Resource.Drawable.shape_rect_red);

            }
            else if (position == 1)
            {

                _viewHolderDailySpends._dailySpendImageView.SetBackgroundResource(Resource.Drawable.shape_rect_yellow);
            }
            else if (position == 2)
            {
                _viewHolderDailySpends._dailySpendImageView.SetBackgroundResource(Resource.Drawable.shape_rect_lightGreen);
            }
            if (position == 3)
            {
                _viewHolderDailySpends._dailySpendImageView.SetBackgroundResource(Resource.Drawable.shape_rect_red);

            }
            else if (position == 4)
            {

                _viewHolderDailySpends._dailySpendImageView.SetBackgroundResource(Resource.Drawable.shape_rect_yellow);
            }
            else if (position == 5)
            {
                _viewHolderDailySpends._dailySpendImageView.SetBackgroundResource(Resource.Drawable.shape_rect_lightGreen);
            }
            if (position == 6)
            {
                _viewHolderDailySpends._dailySpendImageView.SetBackgroundResource(Resource.Drawable.shape_rect_red);

            }
            else if (position == 7)
            {

                _viewHolderDailySpends._dailySpendImageView.SetBackgroundResource(Resource.Drawable.shape_rect_yellow);
            }
            else if (position == 8)
            {
                _viewHolderDailySpends._dailySpendImageView.SetBackgroundResource(Resource.Drawable.shape_rect_lightGreen);
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View v = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.dailySpendListsLayout,parent,false);
            return new ViewHolderDailySpends(v);
        }

        class ViewHolderDailySpends : RecyclerView.ViewHolder
        {
            public ImageView _dailySpendImageView;
            public TextView _dailySpendTextView;
            public TextView _moneyTextView;
            public TextView _dateTextView;
            public ViewHolderDailySpends(View itemView) : base(itemView)
            {
                _dailySpendImageView = itemView.FindViewById<ImageView>(Resource.Id.imageViewDailySpendImage);
                _dailySpendTextView = itemView.FindViewById<TextView>(Resource.Id.textViewDailySpentTitle);
                _moneyTextView = itemView.FindViewById<TextView>(Resource.Id.textViewDailySpentMoney);
                _dateTextView = itemView.FindViewById<TextView>(Resource.Id.textViewDailySpentDate);

            }

            internal void BindData(Spends spends)
            {
                _dailySpendImageView.SetImageResource(spends.PhotoId);
                _dailySpendTextView.Text = spends.DailySpends;
                _moneyTextView.Text = spends.Money;
                _dateTextView.Text = spends.Dates;
            }
        }
    }
}