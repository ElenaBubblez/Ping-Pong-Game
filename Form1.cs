using System;
using System.Linq;
using System.Windows.Forms;

namespace Elenas_New_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }

     
        private void main_submit_button_Click(object sender, EventArgs e)
        {

            //password_box.Text = Console.ReadLine();
            int passwordLength = password_box.Text.Length;
            int minLength = 8;
            int score = 0;


            if (passwordLength >= minLength)
            {
                score++;
            }
            if (password_box.Text.Any(char.IsUpper))
            {
                score++;
            }
            if (password_box.Text.Any(char.IsLower))
            {
                score++;
            }
            if (password_box.Text.Any(char.IsNumber))
            {
                score++;     
            }
            if (password_box.Text.Any(char.IsSymbol))
            {
                score++;
            }
            if (password_box.Text.Any(char.IsPunctuation))
            {
                score++;
            }
            
            switch (score)
            {
                case 1:
                    main_login.Text = "Password strength is weak";
                    break;
                case 2:
                    main_login.Text = "Password strength is medium";
                    break;
                case 3:
                    main_login.Text = "Password strength is strong";
                    break;
                case 4:
                    main_login.Text = "Password strength is extremly strong";
                    break;
                case 5:
                    main_login.Text = "Maximum strength";
                    break;
                default:
                    main_login.Text = "Password is very weak";
                    break;
            }
            if (score == 5)
            {
                Main_Game Mg = new Main_Game();
                this.Visible = false;
                Mg.ShowDialog();
                this.Close();

            }
            
            else
            {
                PasswordInfo.Text = "Password must have a minimum length of 8 characters, contain at least 1 capital letter, 1 lowercase letter, 1 number and 1 special character";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();           
        }
    }
}
