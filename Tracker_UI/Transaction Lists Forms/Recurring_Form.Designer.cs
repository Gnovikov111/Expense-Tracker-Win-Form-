namespace Tracker_UI.Transaction_Lists_Forms
{
    partial class Recurring_Form
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
            this.Recurring_List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Recurring_List
            // 
            this.Recurring_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Recurring_List.FormattingEnabled = true;
            this.Recurring_List.Location = new System.Drawing.Point(0, 0);
            this.Recurring_List.Name = "Recurring_List";
            this.Recurring_List.Size = new System.Drawing.Size(466, 370);
            this.Recurring_List.TabIndex = 0;
            this.Recurring_List.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Recurring_List_MouseDoubleClick);
            // 
            // Recurring_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 370);
            this.Controls.Add(this.Recurring_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recurring_Form";
            this.Text = "Recurring_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Recurring_List;
    }
}