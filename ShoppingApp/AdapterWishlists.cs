using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp
{
    class AdapterWishlists : RecyclerView.Adapter
    {
        private Context context;
        private Wishlists wishlists;

        public AdapterWishlists(Context context, Wishlists wishlists)
        {
            this.context = context;
            this.wishlists = wishlists;
        }

        public override int ItemCount => wishlists.WishListNumbers;

        [Obsolete]
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ViewHolderWishLists _viewHolderWishLists = holder as ViewHolderWishLists;
            _viewHolderWishLists.BindData(wishlists[position]);
            if (position == 0)
            {

                _viewHolderWishLists._cardViewWishlist.SetBackgroundDrawable(context.Resources.GetDrawable(Resource.Drawable.shape_rect_lightBlue));

            }
            else if (position == 1)
            {

                _viewHolderWishLists._cardViewWishlist.SetBackgroundDrawable(context.Resources.GetDrawable(Resource.Drawable.shape_rect_red));

            }
            else if (position == 2)
            {

                _viewHolderWishLists._cardViewWishlist.SetBackgroundDrawable(context.Resources.GetDrawable(Resource.Drawable.shape_rect_yellow));

            }
            else if (position == 3)
            {

                _viewHolderWishLists._cardViewWishlist.SetBackgroundDrawable(context.Resources.GetDrawable(Resource.Drawable.shape_rect_lightGreen));
            }
            else if (position == 4)
            {

                _viewHolderWishLists._cardViewWishlist.SetBackgroundDrawable(context.Resources.GetDrawable(Resource.Drawable.shape_rect_blue));
            }
            if (position == 5)
            {

                _viewHolderWishLists._cardViewWishlist.SetBackgroundDrawable(context.Resources.GetDrawable(Resource.Drawable.shape_rect_lightBlue));

            }
            else if (position == 6)
            {

                _viewHolderWishLists._cardViewWishlist.SetBackgroundDrawable(context.Resources.GetDrawable(Resource.Drawable.shape_rect_red));


            }
            else if (position == 7)
            {

                _viewHolderWishLists._cardViewWishlist.SetBackgroundDrawable(context.Resources.GetDrawable(Resource.Drawable.shape_rect_yellow));

            }
            else if (position == 8)
            {

                _viewHolderWishLists._cardViewWishlist.SetBackgroundDrawable(context.Resources.GetDrawable(Resource.Drawable.shape_rect_lightGreen));
            }
            else if (position == 9)
            {

                _viewHolderWishLists._cardViewWishlist.SetBackgroundDrawable(context.Resources.GetDrawable(Resource.Drawable.shape_rect_blue));
            }

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View _v = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.wishlistListsLayout, parent, false);
            return new ViewHolderWishLists(_v);
        }

        class ViewHolderWishLists : RecyclerView.ViewHolder
        {
            public CardView _cardViewWishlist;
            public ImageView _imageViewWishlist;
            public TextView _textViewWishlist;
            public ViewHolderWishLists(View itemView) : base(itemView)
            {

                _cardViewWishlist = itemView.FindViewById<CardView>(Resource.Id.cardViewWishLists);
                _imageViewWishlist = itemView.FindViewById<ImageView>(Resource.Id.imageViewItemImage);
                _textViewWishlist = itemView.FindViewById<TextView>(Resource.Id.textViewItemName);

            }

            internal void BindData(List list)
            {
                _imageViewWishlist.SetImageResource(list.PhotoId);
                _textViewWishlist.Text = list.Caption;
            }
        }
    }
}