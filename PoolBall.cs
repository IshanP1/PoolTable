using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracP5
{
    class PoolBall : MovingBall
    {
        Random rand = new Random(50);
        Random RANDX = new Random(50);
        int xval;
        int yval;
        int xdis;
        int ydis;

        public PoolBall(int x, int y, int dx, int dy) : base(x, y, dx, dy)
        {
            xval = x;
            yval = y;
            xdis = dx;
            ydis = dy;

        }



        public  void Moves()
        {
            if ((xCoord + xSpeed > 0) && (xCoord + xSpeed <= 233) && (yCoord + ySpeed > 0) && (yCoord + ySpeed < 107))
            {
                Move();
            }
            else
            {
                xSpeed = - xSpeed;
                ySpeed = -ySpeed;

                Move();
            }
        }
       
       
    }
}
