using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kJobs_Client_Side.Properties;

namespace kJobs_Client_Side
{
    public partial class LoginForm : UserControl
    {
        kUtils _kUtils = new kUtils();
        
        public LoginForm()
        {
            InitializeComponent();
            
            textBox_Login_username.Text = "Username";
            textBox_Login_username.ForeColor = Color.FromArgb(10, 0,0,0);

            textBox_Login_passwrd.Text = "Password";
            textBox_Login_passwrd.ForeColor = Color.FromArgb(10, 0, 0, 0);
            textBox_Login_passwrd.UseSystemPasswordChar = true;

        }

        private void textBox_Login_passwrd_TextChanged(object sender, EventArgs e)
        {

        }

        /*104 197 206rbg hover*/
        private void username_field_OnMouseEnter(object sender, EventArgs e)
        {
            underlinefortextbox_username.BackColor = Color.FromArgb(255, 104, 197, 206);
            

            if (textBox_Login_username.Text == "Username")
            {
                textBox_Login_username.Text = "";
                textBox_Login_username.ForeColor = Color.FromArgb(255, 0, 0, 0);
            }
        }

        private void username_field_OnMouseLeave(object sender, EventArgs e)
        {

            if (textBox_Login_username.Text.Length < 1)
            {
                textBox_Login_username.Text = "Username";
                textBox_Login_username.ForeColor = Color.FromArgb(10, 0, 0, 0);
                underlinefortextbox_username.BackColor = Color.Black;

            }
        }

        private void textfield_password_onMouseEnter(object sender, EventArgs e)
        {
            underline_password.BackColor = Color.FromArgb(255, 104, 197, 206);

            if (textBox_Login_passwrd.Text == "Password")
            {
                textBox_Login_passwrd.Text = "";
                textBox_Login_passwrd.ForeColor = Color.FromArgb(255, 0, 0, 0);
            }
        }

        private void textfield_password_onMouseLeave(object sender, EventArgs e)
        {
            if (textBox_Login_passwrd.Text.Length < 1)
            {
                textBox_Login_passwrd.Text = "Password";
                textBox_Login_passwrd.ForeColor = Color.FromArgb(10, 0, 0, 0);
                underline_password.BackColor = Color.Black;

            }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            _kUtils.Login(textBox_Login_username.Text);

            if(_kUtils.Admin.LoggedIn)
            {
                this.Visible = false;
            }

        }

        private void Animation_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.Image = new Bitmap(Resources.login_hovered);

        }

        private void Animation_MouseMove(object sender, EventArgs e)
        {
            LoginButton.Image = new Bitmap(Resources.login);
        }

        private void underlinefortextbox_username_Click(object sender, EventArgs e)
        {

        }

        private void underline_password_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/*login click
 *           _kUtils.Login(textBox_Login_username.Text);

            if(_kUtils.Admin.LoggedIn)
            {
                this.Visible = false;
            }*/