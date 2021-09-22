namespace Tracker_UI.Transaction_Lists
{
    partial class Entertain_Form
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
            this.Entertain_List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Entertain_List
            // 
            this.Entertain_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Entertain_List.FormattingEnabled = true;
            this.Entertain_List.Location = new System.Drawing.Point(0, 0);
            this.Entertain_List.Name = "Entertain_List";
            this.Entertain_List.Size = new System.Drawing.Size(466, 370);
            this.Entertain_List.TabIndex = 0;
            this.Entertain_List.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Entertain_List_MouseDoubleClick);
            // 
            // Entertain_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 370);
            this.Controls.Add(this.Entertain_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entertain_Form";
            this.Text = "Entertain_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Entertain_List;
    }
}