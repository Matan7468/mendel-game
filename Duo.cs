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
    class Duo : Product
    {

        Cell[,] cells;
        Random rnd = new Random();
        int dir;
        public Duo(int x, int y,int dir) :base(x,y,2,false)
        {
            cells = new Cell[3, 3];
            this.dir = dir;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cells[i, j] = new Cell(Cell.CellWidth*i, Cell.CellHeight*j, 1, Cell.CellWidth, Cell.CellHeight);
                }
            }
           
        }
        public override void Draw(Canvas canvas)
        {
            switch (dir)
            {
                case 0://ימין
                    cells[0, 0].ChangeType(2);
                    cells[1, 0].ChangeType(2);
                    break;
                case 1://אלכסון
                    cells[0, 0].ChangeType(2);
                    cells[1, 1].ChangeType(2);
                    break;
                case 2://למטה
                    cells[0, 0].ChangeType(2);
                    cells[0, 1].ChangeType(2);
                    break;
            }
        }

        public override void Update(Canvas canvas)
        {
        }
    }
}