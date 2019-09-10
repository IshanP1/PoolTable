using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracP5
{
    class MovingBall : Ball
    {
        protected int xSpeed;
        Random rand = new Random();
        public int XSpeed
        
        {
            get { return xSpeed; }
            set { xSpeed = value; }
        }
        protected int ySpeed;
        public int YSpeed
        {
            get { return ySpeed; }
            set { ySpeed = value; }
        }
       

        public MovingBall(int x, int y, int dx, int dy)
        {
            xCoord = x;
            yCoord = y;
            xSpeed = dx;
            ySpeed = dy;
        }

       public virtual void Move()
        {
            //if ((xCoord + xSpeed > 0) && (xCoord + xSpeed < 233) && (yCoord + ySpeed > 0) && (yCoord + ySpeed < 117))
            //{

            //    MoveHorizontal(xSpeed);
            //    MoveVertical(ySpeed);

            //}
            //else
            //{
            //    xSpeed = -xSpeed;
            //    ySpeed = -ySpeed;

                MoveHorizontal(xSpeed);
                MoveVertical(ySpeed);
          // }
        }

        public bool CollidesWith(MovingBall anotherBall)
        {
            // Get differences of coords
            int dx = xCoord - anotherBall.xCoord;
            int dy = yCoord - anotherBall.yCoord;

            // Euclidean Distance between the balls
            double dist = Math.Sqrt((double)(dx * dx) + (double)(dy * dy));

            // If distance is less than the diameter, the balls are touching
            return (dist < (double)size);            
        }

        public void Touching(MovingBall anotherBall)
        {
            while (CollidesWith(anotherBall))
            {
                if (X < anotherBall.X)
                    MoveHorizontal(-1);
                else
                    MoveHorizontal(+1);
                if (Y < anotherBall.Y)
                    MoveVertical(-1);
                else
                    MoveVertical(+1);
            }
        }

        public void Bounce(MovingBall anotherBall)
        {
            // Get differences of coords
            int dx = xCoord - anotherBall.xCoord;
            int dy = yCoord - anotherBall.yCoord;

                        //bounce both balls - this is not very accurate :-(
          XSpeed *= -1;
            YSpeed *= -1;  
    
          anotherBall.XSpeed *= -1;
            anotherBall.YSpeed *= -1;

            }
    }
}
