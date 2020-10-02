using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kJobs_Server_Side
{
    public partial class Form1 : Form
    {
        kUtils _kUtils = new kUtils();
        public Form1()
        {
            Thread t = new Thread(_kUtils.RecieveData);
            t.Start();


            InitializeComponent();


            Timer_update_value_in_Dropdown_admin_list.Enabled = true;
            Timer_update_value_in_Dropdown_admin_list.Start();
            adminsOnlineToolStripMenuItem.Text = adminsOnlineToolStripMenuItem.Text + " - " + _kUtils.clientsOnline;

        }

        public void Add_Admins()
        {
            bool foundAdmin = false;

            if (adminsOnlineToolStripMenuItem.DropDownItems.Count < _kUtils.clients.Length)
            {
                foreach (var c in _kUtils.clients)
                {

                    for(int i =0; i < adminsOnlineToolStripMenuItem.DropDownItems.Count; i++)
                    {
                        
                        if (adminsOnlineToolStripMenuItem.DropDownItems[i].Text == c.name)
                        {
                            foundAdmin = true;
                        }
                    }
                
                    
                    if(!foundAdmin && c.name != null)
                    {
                        adminsOnlineToolStripMenuItem.DropDownItems.Add(c.name);
                        foundAdmin = !foundAdmin;
                    }


                    foundAdmin = !foundAdmin;
                }
            }

        }

        public void adminsOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Admins();

            

        }

        private void dropdownitem_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem itemClicked = e.ClickedItem;

            string Data = "";

            for (int i = 0; i < _kUtils.clients.Length; i++) 
            {
                                                                   // check for reformated strings
                if (_kUtils.clients[i].name == itemClicked.Text || itemClicked.Text.Contains(_kUtils.clients[i].name))
                {
                    Data += "Name: " + _kUtils.clients[i].name + "\nTime Alive: " + _kUtils.clients[i].timeAlive;

                    break;
                }

            }


            MessageBox.Show(Data,caption:"Info");

        }

        bool init_AdminOfTheDay_Special = false;
        private void timer_updatE_value_in_dropdown_admin_list(object sender, EventArgs e)
        {
            Debug.WriteLine(_kUtils.AdminsOfTheDay[0].name);

            adminsOnlineToolStripMenuItem.Text = "Admins Online - " + _kUtils.get_AllConnectedAdmins();

            if (!init_AdminOfTheDay_Special && adminsOnlineToolStripMenuItem.DropDownItems.Count > 0)
            {

                //MessageBox.Show(_kUtils.AdminsOfTheDay[0].name + "\n" + _kUtils.AdminsOfTheDay[1].name);
                
                for (int i = 0; i < adminsOnlineToolStripMenuItem.DropDownItems.Count; i++) 
                {
                    if(adminsOnlineToolStripMenuItem.DropDownItems[i].Text == _kUtils.AdminsOfTheDay[0].name || adminsOnlineToolStripMenuItem.DropDownItems[i].Text == _kUtils.AdminsOfTheDay[1].name)
                    {
                        adminsOnlineToolStripMenuItem.DropDownItems[i].Text = "*"+adminsOnlineToolStripMenuItem.DropDownItems[i].Text;
                    }
                }

                init_AdminOfTheDay_Special = true;
            }


        }



    }
}
