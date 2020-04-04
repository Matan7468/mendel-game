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
using System.IO;

namespace mendel_s_game
{
    class GameBoard : Shape
    {
        Cell[,] cell;
        
        public static int NUM_CELLS { get; set; }


        float xHelper;
        float yHelper;

        public GameBoard(int x,int y) : base(x, y, null)
        {
            xHelper = x;
            yHelper = y;
            cell = new Cell[9, 9];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cell[i, j] = new Cell(xHelper, yHelper, 1, Cell.CellWidth, Cell.CellHeight);
                    xHelper += Cell.CellWidth;
                }
                xHelper = 0;
                yHelper += Cell.CellHeight;
            }
        }


        public override void Draw(Canvas canvas)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cell[i, j].Draw(canvas);
                }
            }
            Paint b = new Paint()
            {
                Color = Color.Black
            };
            b.Alpha = 70;

            for (int i = 1; i < NUM_CELLS; i++)
            {
                for (int j = 1; j < NUM_CELLS; j++)
                {
                    if (cell[i, j].num != 0)
                    {
                        canvas.DrawLine(Cell.CellWidth * j, Cell.CellHeight * i, Cell.CellWidth * j, Cell.CellHeight * (i + 1), b);//קווים לאורך
                        canvas.DrawLine(Cell.CellWidth * j, Cell.CellHeight * i, Cell.CellWidth * (j + 1), Cell.CellHeight * i, b);//קווים לרוחב
                    }
                }
            }
        }

        public override void Update(Canvas canvas)
        {
        }
    }
}