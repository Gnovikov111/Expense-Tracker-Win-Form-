namespace Tracker_UI.Transaction_Lists
{
    partial class Food_Form
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
            this.Food_List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Food_List
            // 
            this.Food_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Food_List.FormattingEnabled = true;
            this.Food_List.Location = new System.Drawing.Point(0, 0);
            this.Food_List.Name = "Food_List";
            this.Food_List.Size = new System.Drawing.Size(466, 370);
            this.Food_List.TabIndex = 0;
            this.Food_List.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Food_List_MouseDoubleClick);
            // 
            // Food_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 370);
            this.Controls.Add(this.Food_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Food_Form";
            this.Text = "Food_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Food_List;
    }
}