using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracP5
{
    class ColourPoolBall:PoolBall
    {

        int _xCoord, _yCoord, _yMove, _xMove;
        Color colour;
        public ColourPoolBall(int x, int y, int dx, int dy) : base(x, y, dx, dy)
        {
            //_xCoord = x;
            //_yCoord = y;
            //_xMove = dx;
            //_yMove = dy;
        }

        //public Color getTheColor
        //{
        //    get {
        //        colour = colours[rand.Next(12)];
        //        return colour; }
        //}
        public Color  GetCol(int ballNum)
        {
            colour = colours[ballNum];
            return colour;
        }

        Random rand = new Random( );
        Color[] colours = new Color[16] { Color.Yellow, Color.Red, Color.Blue, Color.Green, Color.Gray, Color.HotPink, Color.Khaki, Color.Lavender, Color.Maroon, Color.Lime,
        Color.MidnightBlue, Color.YellowGreen, Color.Aquamarine, Color.Beige, Color.BlanchedAlmond, Color.AliceBlue};

               
         
            
            
        



        //
    }
}
