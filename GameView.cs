using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;

namespace mendel_s_game
{
    class GameView:SurfaceView
    {
        Thread game;
        bool gameRunning;
        GameBoard GameBoard;
        Products products;
        public GameView(Context context):base(context)
        {
            GameBoard = new GameBoard(250, 500);
            game = new Thread(Run);
            gameRunning = true;
            products = new Products(0, 1500);
            game.Start();
        }
        public void Run()
        {
            while (gameRunning)
            {
                if (Holder.Surface.IsValid)
                {
                    Canvas canvas = Holder.LockCanvas();

                    Update(canvas);
                    Draw(canvas);

                }
            }
        }

        public override void Draw(Canvas canvas)
        {
            base.Draw(canvas);

            GameBoard.Draw(canvas);
            products.Draw(canvas);
        }
        public void Update(Canvas canvas)
        {
            products.Update(canvas); 
        }
    }
}