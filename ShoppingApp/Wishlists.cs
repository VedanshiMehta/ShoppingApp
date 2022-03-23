using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp
{
    class List
    {
        public List(int photoId,string caption, int background)
        {
            PhotoId = photoId;
            Caption = caption;
            Background = background;
        }

        public int PhotoId { get; private set; }
        public string Caption { get; private set; }
        public int Background { get; private set; }
    }
    class Wishlists
    {
        static List[] wishLists =
        {
            new List(Resource.Drawable.ic_camera,"Cameras",Resource.Drawable.shape_rect_blue),
            new List(Resource.Drawable.ic_money,"Savings",Resource.Drawable.shape_rect_red),
            new List(Resource.Drawable.ic_bike,"Bike",Resource.Drawable.shape_rect_yellow),
            new List(Resource.Drawable.ic_gym,"Gym",Resource.Drawable.shape_rect_lightGreen),
            new List(Resource.Drawable.ic_tee,"Tee", Resource.Drawable.shape_rect_blue),
             new List(Resource.Drawable.ic_camera,"Cameras",Resource.Drawable.shape_rect_blue),
            new List(Resource.Drawable.ic_money,"Savings",Resource.Drawable.shape_rect_red),
            new List(Resource.Drawable.ic_bike,"Bike",Resource.Drawable.shape_rect_yellow),
            new List(Resource.Drawable.ic_gym,"Gym",Resource.Drawable.shape_rect_lightGreen),
            new List(Resource.Drawable.ic_tee,"Tee", Resource.Drawable.shape_rect_blue),





        };

        private List[] newList;

        public Wishlists()
        {
            newList = wishLists;
        }

        public int WishListNumbers
        { 
            get { return newList.Length; }
        }

        public List this[int i]
        {
            get { return newList[i]; }
        
        }
    }
}