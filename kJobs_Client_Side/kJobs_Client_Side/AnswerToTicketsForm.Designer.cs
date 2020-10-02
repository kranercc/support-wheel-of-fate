namespace kJobs_Client_Side
{
    partial class AnswerToTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerToTicketsForm));
            this.ticket_text_box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Solved = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ticket_text_box
            // 
            this.ticket_text_box.BackColor = System.Drawing.SystemColors.Window;
            this.ticket_text_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticket_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_text_box.Location = new System.Drawing.Point(156, 116);
            this.ticket_text_box.Name = "ticket_text_box";
            this.ticket_text_box.ReadOnly = true;
            this.ticket_text_box.Size = new System.Drawing.Size(495, 193);
            this.ticket_text_box.TabIndex = 0;
            this.ticket_text_box.Text = resources.GetString("ticket_text_box.Text");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(94, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 397);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Image = global::kJobs_Client_Side.Properties.Resources.support_icon_resized;
            this.label2.Location = new System.Drawing.Point(348, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 68);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(571, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 68);
            this.label3.TabIndex = 5;
            // 
            // btn_Solved
            // 
            this.btn_Solved.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Solved.Image = global::kJobs_Client_Side.Properties.Resources.solved4;
            this.btn_Solved.Location = new System.Drawing.Point(153, 312);
            this.btn_Solved.Name = "btn_Solved";
            this.btn_Solved.Size = new System.Drawing.Size(70, 67);
            this.btn_Solved.TabIndex = 6;
            this.btn_Solved.Click += new System.EventHandler(this.Buton_Solved_Click);
            this.btn_Solved.MouseEnter += new System.EventHandler(this.btn_Solved_Enter);
            this.btn_Solved.MouseLeave += new System.EventHandler(this.btn_Solved_Leave);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Next.Image = global::kJobs_Client_Side.Properties.Resources.next3;
            this.btn_Next.Location = new System.Drawing.Point(581, 312);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(70, 67);
            this.btn_Next.TabIndex = 7;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            this.btn_Next.MouseEnter += new System.EventHandler(this.btn_Next_Enter);
            this.btn_Next.MouseLeave += new System.EventHandler(this.btn_Next_Leave);
            // 
            // AnswerToTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Solved);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ticket_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnswerToTicketsForm";
            this.Size = new System.Drawing.Size(804, 454);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ticket_text_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btn_Solved;
        private System.Windows.Forms.Label btn_Next;
    }
}
