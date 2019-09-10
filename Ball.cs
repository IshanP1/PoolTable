using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracP5
{
    public class Ball : Sphere
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Ball()
        {
        }

        /// <summary>
        /// alternative constructor that places the ball at position x,y
        /// </summary>
        /// <param name="x">The initial x position of the ball</param>
        /// <param name="y">The initial y position of the ball</param>
        public Ball(int x, int y)
        {
            xCoord = x;
            yCoord = y;
        }
     
        /// <summary>
        /// Move the ball horizontally by the value dx.
        /// </summary>
        /// <param name="dx">Amount to move the ball horizontally. Positive value means right, negative means left</param>
        public void MoveHorizontal(int dx)
        {
            xCoord += dx;
        }

        /// <summary>
        /// Move the ball vertically by the value dy.
        /// </summary>
        /// <param name="dy">Amount to move the ball vertically. Positive value means down, negative means up</param>
        public void MoveVertical(int dy)
        {
            yCoord += dy;
        }
    }
    
}
