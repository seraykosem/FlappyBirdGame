using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class FlappyBirdGame : Form
    {

        int pipeSpeed  = 8;
        int gravity = 10;
        int score = 0;
        public FlappyBirdGame()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipedown.Left -= pipeSpeed;
            pipe.Left -= pipeSpeed;
            Score.Text = "Score: " + score;


            if(pipedown.Left< -150)
            {
                pipe.Left = 800;
                score ++;
                
            }
            if (pipe.Left < -10)
            {
                pipedown.Left = 950;
                score ++;

            }
            if (flappybird.Bounds.IntersectsWith(pipedown.Bounds)||flappybird.Bounds.IntersectsWith(pipe.Bounds) || flappybird.Bounds.IntersectsWith(ground.Bounds))
            
            {
                endGame();
            }
            if(score>5)
            {
                pipeSpeed = 15;
            }
            if (flappybird.Top < -25)
            {
                endGame();
            }
            



        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Space)
            {
                gravity = -15;

            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;

            }
        }
        private void endGame()
        {
            GameTimer.Stop();
            Score.Text += "Game Over !!!";
        }
    }
}
