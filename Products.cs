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
    class Products
    {
        List<Product> products;
        Random rnd;
        int x, y;
        public Products(int x,int y)
        {
            this.x = x;
            this.y = y;

            products = new List<Product>();
            rnd = new Random();
        }

        public void Draw(Canvas canvas)
        {
            for (int i = 0; i < 3; i++)
            {
                products[i].Draw(canvas);
            }
        }
        public void Update(Canvas canvas)
        {
            if (products.Count == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    products.Add(AddPro(rnd.Next(0, 1), 0));
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (products[i].used)
                {
                    products.RemoveAt(i);
                }
            }
        }

        public Product AddPro(int x,int place)
        {
            switch (x)
            {
                case 0:
                    return new Duo(this.x + 500 + Product.width*place , y, rnd.Next(0, 3));
            }
            return new Duo(x * place + 500, y, rnd.Next(0, 3));
        }
    }
}