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
    class Spends
    {
        public Spends(int photoId, string dailySpends, string money , string dates, int background)
        {
            PhotoId = photoId;
            DailySpends = dailySpends;
            Money = money;
            Dates = dates;
            Background = background;
        }

        public int PhotoId { get; private set; }
        public string DailySpends { get; private set; }
        public string Money { get; private set; }
        public string Dates { get; private set; }
        public int Background { get; private set; }
    }
    class DailySpends
    {
        static Spends[] spendList =
        { 

            new Spends(Resource.Drawable.ic_bank,"Net Banking","$365.89","Today",Resource.Drawable.shape_rect_red),
            new Spends(Resource.Drawable.ic_food,"Food & Drinks","$165.99","26 Jan,2019",Resource.Drawable.shape_rect_yellow),
            new Spends(Resource.Drawable.ic_dress,"Clothes","$65.09","15 Jan,2019",Resource.Drawable.shape_rect_lightGreen),
            new Spends(Resource.Drawable.ic_bank,"Net Banking","$365.89","Today",Resource.Drawable.shape_rect_red),
            new Spends(Resource.Drawable.ic_food,"Food & Drinks","$165.99","26 Jan,2019",Resource.Drawable.shape_rect_yellow),
            new Spends(Resource.Drawable.ic_dress,"Clothes","$65.09","15 Jan,2019",Resource.Drawable.shape_rect_lightGreen),
            new Spends(Resource.Drawable.ic_bank,"Net Banking","$365.89","Today",Resource.Drawable.shape_rect_red),
            new Spends(Resource.Drawable.ic_food,"Food & Drinks","$165.99","26 Jan,2019",Resource.Drawable.shape_rect_yellow),
            new Spends(Resource.Drawable.ic_dress,"Clothes","$65.09","15 Jan,2019",Resource.Drawable.shape_rect_lightGreen),



        };

        private Spends[] spends;

        public DailySpends()
        {
            spends = spendList;
        }

        public int SpendNumbers
        {
            get { return spends.Length; }
        }

        public Spends this[int i]
        { 
            get { return spends[i]; }
        }
    }
}