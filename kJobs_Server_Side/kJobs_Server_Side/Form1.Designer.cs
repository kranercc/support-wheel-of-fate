namespace kJobs_Server_Side
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminsOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_update_value_in_Dropdown_admin_list = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminsOnlineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminsOnlineToolStripMenuItem
            // 
            this.adminsOnlineToolStripMenuItem.Name = "adminsOnlineToolStripMenuItem";
            this.adminsOnlineToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.adminsOnlineToolStripMenuItem.Text = "Admins Online";
            this.adminsOnlineToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dropdownitem_Clicked);
            this.adminsOnlineToolStripMenuItem.Click += new System.EventHandler(this.adminsOnlineToolStripMenuItem_Click);
            // 
            // Timer_update_value_in_Dropdown_admin_list
            // 
            this.Timer_update_value_in_Dropdown_admin_list.Interval = 2000;
            this.Timer_update_value_in_Dropdown_admin_list.Tick += new System.EventHandler(this.timer_updatE_value_in_dropdown_admin_list);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Server Side Controller";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminsOnlineToolStripMenuItem;
        private System.Windows.Forms.Timer Timer_update_value_in_Dropdown_admin_list;
    }
}

