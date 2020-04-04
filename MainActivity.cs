using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Graphics;
using System.IO;

namespace mendel_s_game
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            GameView gameView = new GameView(this);
            Point screenSize = new Point();
            this.WindowManager.DefaultDisplay.GetSize(screenSize);

            Cell.CellWidth = (screenSize.X - 100) / GameBoard.NUM_CELLS;
            Cell.CellHeight = (screenSize.Y - 1000) / GameBoard.NUM_CELLS;

            SetContentView(gameView);

        }

    }
}