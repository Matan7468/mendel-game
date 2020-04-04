using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace mendel_s_game
{
    public abstract class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public Paint MyPaint { get; set; }

        public Shape(int x, int y, Paint paint)
        {
            this.x = x;
            this.y = y;
            this.MyPaint = paint;
        }

        public abstract void Draw(Canvas canvas);
        public abstract void Update(Canvas canvas);
    }
}