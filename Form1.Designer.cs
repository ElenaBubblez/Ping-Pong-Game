namespace Elenas_New_Game
{
    partial class Form1
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
            this.main_login = new System.Windows.Forms.TextBox();
            this.main_submit_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.PasswordInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // main_login
            // 
            this.main_login.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.main_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.main_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_login.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_login.HideSelection = false;
            this.main_login.Location = new System.Drawing.Point(276, 226);
            this.main_login.Name = "main_login";
            this.main_login.ReadOnly = true;
            this.main_login.Size = new System.Drawing.Size(558, 26);
            this.main_login.TabIndex = 1;
            this.main_login.TabStop = false;
            this.main_login.Text = "Create an account";
            this.main_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // main_submit_button
            // 
            this.main_submit_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.main_submit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.main_submit_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.main_submit_button.FlatAppearance.BorderSize = 0;
            this.main_submit_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.main_submit_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.main_submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_submit_button.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_submit_button.Location = new System.Drawing.Point(448, 501);
            this.main_submit_button.Name = "main_submit_button";
            this.main_submit_button.Size = new System.Drawing.Size(190, 45);
            this.main_submit_button.TabIndex = 5;
            this.main_submit_button.Text = "Submit";
            this.main_submit_button.UseVisualStyleBackColor = false;
            this.main_submit_button.Click += new System.EventHandler(this.main_submit_button_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(416, 334);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(86, 24);
            this.username_label.TabIndex = 6;
            this.username_label.Text = "Username:";
            this.username_label.UseCompatibleTextRendering = true;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(416, 388);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(83, 24);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Password:";
            this.password_label.UseCompatibleTextRendering = true;
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(509, 334);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(176, 26);
            this.username_box.TabIndex = 8;
            // 
            // password_box
            // 
            this.password_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password_box.Location = new System.Drawing.Point(509, 382);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(176, 26);
            this.password_box.TabIndex = 9;
            // 
            // PasswordInfo
            // 
            this.PasswordInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInfo.Enabled = false;
            this.PasswordInfo.Location = new System.Drawing.Point(301, 440);
            this.PasswordInfo.Multiline = true;
            this.PasswordInfo.Name = "PasswordInfo";
            this.PasswordInfo.ReadOnly = true;
            this.PasswordInfo.Size = new System.Drawing.Size(560, 43);
            this.PasswordInfo.TabIndex = 10;
            this.PasswordInfo.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.main_submit_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1054, 748);
            this.Controls.Add(this.PasswordInfo);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.main_submit_button);
            this.Controls.Add(this.main_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.TransparencyKey = System.Drawing.Color.SteelBlue;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox main_login;
        private System.Windows.Forms.Button main_submit_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox PasswordInfo;
    }
}

