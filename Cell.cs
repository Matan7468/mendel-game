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
    class Cell:Shape
    {

        public static float CellWidth { get; set; }
        public static float CellHeight { get; set; }

        float width;
        float Height;

        public enum Type
        {
            nothing,
            empty,
            userGreen,
            botBlue,
            botRed,
        }

        public int num { get; set; }

        public Cell(float x, float y,int num, float width, float height) :base((int)x,(int)y,null)
        {
            this.num = num;
            this.width = width;
            this.Height = height;
        }

        public override void Draw(Canvas canvas)
        {
            Paint ccell = new Paint();
            switch (num)
            {
                case (int)Type.nothing:
                    ccell.Color = Color.WhiteSmoke;
                    break;
                case (int)Type.empty:
                    ccell.Color = Color.LightGray;
                    break;
                case (int)Type.userGreen:
                    ccell.Color = Color.Green;
                    break;
                case (int)Type.botBlue:
                    ccell.Color = Color.Blue;
                    break;
                case (int)Type.botRed:
                    ccell.Color = Color.Red;
                    break;
            }

            Rect r = new Rect();

            r.Set((int)x, (int)y, (int)(x + width), (int)(y + Height));
            canvas.DrawRect(r, ccell);

        }

        public override void Update(Canvas canvas)
        {
        }

        public void ChangeType(int num)
        {
            this.num = num;
        }
    }
}