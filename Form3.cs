using System;
using System.Drawing;
using System.Windows.Forms;

namespace Elenas_New_Game
{
    public partial class Main_Game : Form
    {
        private bool keyUp = false;
        private bool keyDown = false;
        private bool keyW = false;
        private bool keyS = false;
        private bool keySpace = false;
        private int ballX = 10;
        private int ballY = 10;
        int p1score = 0;
        int p2score = 0;
        
        

        public Main_Game()
        {
            InitializeComponent();
            tmr_Pic.Start();
            pictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

        
        }


        private void Main_Game_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.W)
            {
               keyW = true;

            }

            if (e.KeyCode == Keys.S)
            {
                keyS = true;
            }


            if (e.KeyCode == Keys.Up)
            {
                keyUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                keyDown = true;
            }
            
            if(e.KeyCode == Keys.Space)
            {
                keySpace = true;
            }
          
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Player1Score.Text = "Player1 Score:" + p1score;
            Player2Score.Text = "Player2 Score:" + p2score;
            fence.Left = ClientSize.Width / 2;
            

            if (GetPictureBox1Location() >= 0)
            {
                if (keyW == true)
                {
                    pictureBox1.Top -= 8;
                }
            }

            if (GetPictureBox1Location() <= Main_Game.ActiveForm.Size.Height - pictureBox1.Size.Height)
            {
                if (keyS == true)
                {
                    pictureBox1.Top += 8;
                }
            }

            if (GetPictureBox2Location() >= 0)
            {
                if (keyUp == true)
                {
                    pictureBox2.Top -= 8;
                }
            }


            if (GetPictureBox2Location() <= Main_Game.ActiveForm.Size.Height - pictureBox1.Size.Height)
            {
                if (keyDown == true)
                {
                    pictureBox2.Top += 8;
                }
            }

            if (keySpace == true)
            {

                ball.Top -= ballY;
                ball.Left -= ballX;
                spaceStart.Hide();
                p1Control.Hide();
                p2Control.Hide();

            }


            if (ball.Left <= 0)
            {

                  ball.Left = ClientSize.Width / 2 - 10;//ball set to start point 
                  ball.Top = ClientSize.Height / 2;
                  ballX = -ballX;
                  p2score++; //adds 1 to player 2 score
                  keySpace = false;
            }

            if (ball.Left + ball.Width >= ClientSize.Width)
            {
                ball.Left = ClientSize.Width / 2 - 10;//ball set to start point 
                ball.Top = ClientSize.Height / 2;
                ballX = +ballX;    
                p1score++; //adds 1 to player 2 score
                keySpace = false;
            }

            if (ball.Top <= 0 || ball.Top + ball.Height >= ClientSize.Height)
            {
                ballY = -ballY; //ball bounces off part of screen it hits.
            }

            if(ball.Bounds.IntersectsWith(pictureBox1.Bounds) || ball.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
            ballX = -ballX;
                
            }

            if (p1score == 10)
            {
            tmr_Pic.Stop();
            WinLabel.Left = 202;
            WinLabel.Text = "Player 1 Wins!";
            Rematch.Visible = true;
            Rematch.Enabled = true;
          
            }


            if (p2score == 10)
            {
                tmr_Pic.Stop();
                WinLabel.Left = 202;
                WinLabel.Text = "Player 2 Wins!";
                Rematch.Visible = true;
                Rematch.Enabled = true;
            }





        }

        private void Main_Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                keyW = false;

            }

            if (e.KeyCode == Keys.S)
            {
                keyS = false;
            }


            if (e.KeyCode == Keys.Up)
            {
                keyUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                keyDown = false;
            }

            
        }

        private int GetPictureBox1Location()
        {
            return pictureBox1.Location.Y;
        }

        private int GetPictureBox2Location()
        {
            return pictureBox2.Location.Y;
        }

        private void Rematch_Click(object sender, EventArgs e)
        {
            Main_Game main = new Main_Game();
            this.Visible = false;
            main.ShowDialog();
            this.Close(); //Closes old form 
        
        }

        private void Main_Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
