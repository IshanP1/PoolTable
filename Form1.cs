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
    public partial class Form1 : Form
    {
        // The number of balls to display
        private const int NUM_BALLS = 16;
       
        // List to hold the balls
        private List<Ball> balls = new List<Ball>();
        private List<Color> ballsColor = new List<Color>();
       
        PoolBall p;
        ColourPoolBall cpb;
        // Random object
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        /// <summary>
        /// Initialize the ball list and start the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
          
            balls = new List<Ball>();
            ballsColor = new List<Color>();
          
            //generate balls in random positions, at random speeds
            //while loop since we don't want to generate two balls that overlap
            int i = 0;
            while (i < NUM_BALLS)
            {
                //new ball position is inside table, and speed is in range -3 to +3
               // MovingBall newBall = new MovingBall(random.Next(1, 233), random.Next(1, 117), random.Next(7) - 3, random.Next(7) - 3);

               // p = new PoolBall(newBall.XSpeed, newBall.YSpeed, newBall.X, newBall.Y);
              //  p=new PoolBall(random.Next(1, 233), random.Next(1, 117), random.Next(7) - 3, random.Next(7) - 3);

                cpb = new ColourPoolBall(random.Next(1, 233), random.Next(1, 117), random.Next(7) - 3, random.Next(7) - 3);

                //check if overlaps any existing balls
                if (!CheckOverlaps(cpb))
                { //ball position is good, so add it
                    balls.Add(cpb);
                  // ballsColor.Add(cpb.getTheColor);
                    i++; //add 1 to ball count
                }

                
            }
        

            //start timer for movement
            timerTime.Enabled = true;
        }

        /// <summary>
        /// Update the positions of the balls randomly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            int i = 0;
            pictureBoxTable.Refresh();
            Graphics paper = pictureBoxTable.CreateGraphics();



            // Update position of each ball
            foreach (ColourPoolBall b in balls)
            {
                

                //move the ball
                b.Moves();

                //check if ball is colliding to change their direction
                CheckCollisions(b);

                // draw the ball
             b.Display(paper, i);
                i++;
            }
        }

        private void CheckCollisions(MovingBall ball)
        {
            // Make list of balls to check collisions against
            List<MovingBall> collisionList = new List<MovingBall>();
            foreach (ColourPoolBall b in balls)
            {
                collisionList.Add(b);
            }

            // Remove ball as we don't need to see if ball collides with itself
            collisionList.Remove(ball);

            // Check for collision with every other ball
            foreach (ColourPoolBall b2 in collisionList)
            {
                if (ball.CollidesWith(b2))
                {
                    ball.Touching(b2);
                    //bounce both balls - this is not very accurate :-(
                    ball.XSpeed *= -1;
                    ball.YSpeed *= -1;

                    b2.XSpeed *= -1;
                    b2.YSpeed *= -1;
                }
            }
        }

        private bool CheckOverlaps(MovingBall ball)
        {
            //check if overlaps any existing balls
            foreach (ColourPoolBall b in balls)
            {
                if (ball.CollidesWith(b))
                {
                    ball.Touching(b);
                    return true; //found an overlap
                }
            }
            return false; //got to end of loop, so no overlaps
        }
    }
}

