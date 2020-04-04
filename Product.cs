using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace mendel_s_game
{
    public abstract class Product : Shape
    {
        int length;
        public static int width { get; set; }
        public bool used { get; set; }

        public Product(int x,int y,int length,bool used) : base(x, y, null)
        {
            this.length = length;

            Product.width = (int)Cell.CellWidth * 3;
            this.used = used;
        }

        public override void Draw(Canvas canvas)
        {
        }

        public override void Update(Canvas canvas)
        {
        }
    }
}