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
            
            _viewHolderDailySpends._dailySpendImageView.SetBackgroundResource(dailySpends[position].Background);

            
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