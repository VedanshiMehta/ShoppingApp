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
        public List(int photoId,string caption)
        {
            PhotoId = photoId;
            Caption = caption;
        }

        public int PhotoId { get; private set; }
        public string Caption { get; private set; }
    }
    class Wishlists
    {
        static List[] wishLists =
        {
            new List(Resource.Drawable.ic_camera,"Cameras"),
            new List(Resource.Drawable.ic_money,"Savings"),
            new List(Resource.Drawable.ic_bike,"Bike"),
            new List(Resource.Drawable.ic_gym,"Gym"),
            new List(Resource.Drawable.ic_tee,"Tee"),
            new List(Resource.Drawable.ic_camera,"Cameras"),
            new List(Resource.Drawable.ic_money,"Savings"),
            new List(Resource.Drawable.ic_bike,"Bike"),
            new List(Resource.Drawable.ic_gym,"Gym"),
            new List(Resource.Drawable.ic_tee,"Tee"),





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