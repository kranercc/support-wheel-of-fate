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
    public partial class AnswerToTicketsForm : UserControl
    {
        public AnswerToTicketsForm()
        {
            InitializeComponent();
            btn_Solved.Visible = true;
        }

        private void Buton_Solved_Click(object sender, EventArgs e)
        {
            new kUtils().SendData("update");

        }

        private void btn_Solved_Enter(object sender, EventArgs e)
        {
            btn_Solved.Image = new Bitmap(Resources.solved_hovered4);
        }

        private void btn_Solved_Leave(object sender, EventArgs e)
        {
            btn_Solved.Image = new Bitmap(Resources.solved);
        }

        private void btn_Next_Enter(object sender, EventArgs e)
        {
            btn_Next.Image = new Bitmap(Resources.next_hovered);
        }

        private void btn_Next_Leave(object sender, EventArgs e)
        {
            btn_Next.Image = new Bitmap(Resources.next);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            /* request from DB to get a new ticket */
            ticket_text_box.Text = "New Ticket Generated";
        }
    }
}//new kUtils().SendData("ProblemSolved");
