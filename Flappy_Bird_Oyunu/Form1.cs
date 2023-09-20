using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Oyunu
{
    public partial class Form1 : Form
    {
        int boruHizi = 8;
        int yerçekimi = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            PcbFlappyBird.Top += yerçekimi;
            PcbBoruAlt.Left -= boruHizi;
            PcbBoruUst.Left -= boruHizi;
            LblScore.Text = "Score:" + score;

            if (PcbBoruAlt.Left <- 150)
            {
                PcbBoruAlt.Left = 800;
                score++;
            }
            if (PcbBoruUst.Left <- 180)
            {
                PcbBoruUst.Left = 950;
                score++;
            }
            if (PcbFlappyBird.Bounds.IntersectsWith(PcbBoruAlt.Bounds) || PcbFlappyBird.Bounds.IntersectsWith(PcbBoruUst.Bounds) || PcbFlappyBird.Bounds.IntersectsWith(PcbZemin.Bounds))
            {
                endGame();
            }
            if (score > 5)
            {
                boruHizi = 15;
            }
            if (PcbFlappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerçekimi = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerçekimi = 10;
            }
        }

        private void endGame()
        {
            GameTimer.Stop();
            LblScore.Text = "Game Over !!!";
        } 
    }
}
