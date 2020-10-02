namespace kJobs_Client_Side
{
    partial class LoginForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textBox_Login_username = new System.Windows.Forms.TextBox();
            this.textBox_Login_passwrd = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Label();
            this.underlinefortextbox_username = new System.Windows.Forms.Label();
            this.underline_password = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Login_username
            // 
            this.textBox_Login_username.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Login_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Login_username.Location = new System.Drawing.Point(277, 179);
            this.textBox_Login_username.Name = "textBox_Login_username";
            this.textBox_Login_username.Size = new System.Drawing.Size(196, 15);
            this.textBox_Login_username.TabIndex = 1;
            this.textBox_Login_username.TextChanged += new System.EventHandler(this.textBox_Login_username_TextChanged);
            this.textBox_Login_username.MouseEnter += new System.EventHandler(this.username_field_OnMouseEnter);
            this.textBox_Login_username.MouseLeave += new System.EventHandler(this.username_field_OnMouseLeave);
            // 
            // textBox_Login_passwrd
            // 
            this.textBox_Login_passwrd.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Login_passwrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Login_passwrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Login_passwrd.Location = new System.Drawing.Point(277, 235);
            this.textBox_Login_passwrd.Name = "textBox_Login_passwrd";
            this.textBox_Login_passwrd.Size = new System.Drawing.Size(196, 15);
            this.textBox_Login_passwrd.TabIndex = 2;
            this.textBox_Login_passwrd.TextChanged += new System.EventHandler(this.textBox_Login_passwrd_TextChanged);
            this.textBox_Login_passwrd.MouseEnter += new System.EventHandler(this.textfield_password_onMouseEnter);
            this.textBox_Login_passwrd.MouseLeave += new System.EventHandler(this.textfield_password_onMouseLeave);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.Window;
            this.LoginButton.Image = global::kJobs_Client_Side.Properties.Resources.login;
            this.LoginButton.Location = new System.Drawing.Point(336, 287);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(74, 76);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.MouseEnter += new System.EventHandler(this.Animation_MouseEnter);
            this.LoginButton.MouseLeave += new System.EventHandler(this.Animation_MouseMove);
            // 
            // underlinefortextbox_username
            // 
            this.underlinefortextbox_username.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlinefortextbox_username.Location = new System.Drawing.Point(275, 202);
            this.underlinefortextbox_username.Name = "underlinefortextbox_username";
            this.underlinefortextbox_username.Size = new System.Drawing.Size(200, 5);
            this.underlinefortextbox_username.TabIndex = 5;
            this.underlinefortextbox_username.Click += new System.EventHandler(this.underlinefortextbox_username_Click);
            // 
            // underline_password
            // 
            this.underline_password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underline_password.Location = new System.Drawing.Point(275, 258);
            this.underline_password.Name = "underline_password";
            this.underline_password.Size = new System.Drawing.Size(200, 5);
            this.underline_password.TabIndex = 6;
            this.underline_password.Click += new System.EventHandler(this.underline_password_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(216, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 315);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(318, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 56);
            this.label3.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.underline_password);
            this.Controls.Add(this.underlinefortextbox_username);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.textBox_Login_passwrd);
            this.Controls.Add(this.textBox_Login_username);
            this.Controls.Add(this.label2);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(804, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Login_username;
        private System.Windows.Forms.TextBox textBox_Login_passwrd;
        private System.Windows.Forms.Label LoginButton;
        private System.Windows.Forms.Label underlinefortextbox_username;
        private System.Windows.Forms.Label underline_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
