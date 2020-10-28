namespace Elenas_New_Game
{
    partial class Main_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr_Pic = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fence = new System.Windows.Forms.PictureBox();
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.WinLabel = new System.Windows.Forms.Label();
            this.Rematch = new System.Windows.Forms.Button();
            this.p1Control = new System.Windows.Forms.Label();
            this.p2Control = new System.Windows.Forms.Label();
            this.spaceStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fence)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_Pic
            // 
            this.tmr_Pic.Interval = 10;
            this.tmr_Pic.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.ErrorImage = global::Elenas_New_Game.Properties.Resources.ping_pong_ball;
            this.ball.Image = global::Elenas_New_Game.Properties.Resources.ping_pong_ball;
            this.ball.InitialImage = global::Elenas_New_Game.Properties.Resources.ping_pong_ball;
            this.ball.Location = new System.Drawing.Point(630, 492);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(44, 47);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 4;
            this.ball.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Elenas_New_Game.Properties.Resources.PingPong;
            this.pictureBox2.Location = new System.Drawing.Point(1197, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Elenas_New_Game.Properties.Resources.PingPong;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // fence
            // 
            this.fence.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fence.BackColor = System.Drawing.Color.Linen;
            this.fence.Location = new System.Drawing.Point(642, 0);
            this.fence.Name = "fence";
            this.fence.Size = new System.Drawing.Size(12, 999);
            this.fence.TabIndex = 1;
            this.fence.TabStop = false;
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.Location = new System.Drawing.Point(516, 9);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(111, 20);
            this.Player1Score.TabIndex = 7;
            this.Player1Score.Text = "Player1 Score:";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.Location = new System.Drawing.Point(670, 9);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(111, 20);
            this.Player2Score.TabIndex = 8;
            this.Player2Score.Text = "Player2 Score:";
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.BackColor = System.Drawing.Color.Transparent;
            this.WinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinLabel.Location = new System.Drawing.Point(502, 338);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(0, 108);
            this.WinLabel.TabIndex = 9;
            // 
            // Rematch
            // 
            this.Rematch.Location = new System.Drawing.Point(542, 668);
            this.Rematch.Name = "Rematch";
            this.Rematch.Size = new System.Drawing.Size(220, 67);
            this.Rematch.TabIndex = 10;
            this.Rematch.Text = "Rematch";
            this.Rematch.UseVisualStyleBackColor = true;
            this.Rematch.Visible = false;
            this.Rematch.Click += new System.EventHandler(this.Rematch_Click);
            // 
            // p1Control
            // 
            this.p1Control.AutoSize = true;
            this.p1Control.Location = new System.Drawing.Point(538, 62);
            this.p1Control.Name = "p1Control";
            this.p1Control.Size = new System.Drawing.Size(76, 80);
            this.p1Control.TabIndex = 11;
            this.p1Control.Text = "Controls: \r\nUp =  w\r\nDown = s\r\n\r\n";
            // 
            // p2Control
            // 
            this.p2Control.AutoSize = true;
            this.p2Control.Location = new System.Drawing.Point(670, 62);
            this.p2Control.Name = "p2Control";
            this.p2Control.Size = new System.Drawing.Size(153, 80);
            this.p2Control.TabIndex = 12;
            this.p2Control.Text = "Controls: \r\nUp =  Up Arrow\r\nDown = Down Arrow\r\n\r\n";
            // 
            // spaceStart
            // 
            this.spaceStart.AutoSize = true;
            this.spaceStart.Location = new System.Drawing.Point(670, 359);
            this.spaceStart.Name = "spaceStart";
            this.spaceStart.Size = new System.Drawing.Size(176, 20);
            this.spaceStart.TabIndex = 13;
            this.spaceStart.Text = "Press Spacebar to start";
            // 
            // Main_Game
            // 
            this.AcceptButton = this.Rematch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1295, 997);
            this.Controls.Add(this.spaceStart);
            this.Controls.Add(this.p2Control);
            this.Controls.Add(this.p1Control);
            this.Controls.Add(this.Rematch);
            this.Controls.Add(this.WinLabel);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fence);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Game_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fence;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer tmr_Pic;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.Label WinLabel;
        private System.Windows.Forms.Button Rematch;
        private System.Windows.Forms.Label p1Control;
        private System.Windows.Forms.Label p2Control;
        private System.Windows.Forms.Label spaceStart;
        private System.Windows.Forms.PictureBox ball;
    }
}