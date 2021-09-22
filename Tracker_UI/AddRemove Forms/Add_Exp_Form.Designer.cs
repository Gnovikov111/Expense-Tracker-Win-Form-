namespace Tracker_UI
{
    partial class Add_Exp_Form
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
            this.Exp_Name_Text = new System.Windows.Forms.TextBox();
            this.Exp_Cost_Text = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpCat_Combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Warn_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exp_Name_Text
            // 
            this.Exp_Name_Text.Location = new System.Drawing.Point(156, 55);
            this.Exp_Name_Text.Name = "Exp_Name_Text";
            this.Exp_Name_Text.Size = new System.Drawing.Size(126, 20);
            this.Exp_Name_Text.TabIndex = 0;
            // 
            // Exp_Cost_Text
            // 
            this.Exp_Cost_Text.Location = new System.Drawing.Point(156, 102);
            this.Exp_Cost_Text.Name = "Exp_Cost_Text";
            this.Exp_Cost_Text.Size = new System.Drawing.Size(126, 20);
            this.Exp_Cost_Text.TabIndex = 1;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.ForeColor = System.Drawing.Color.White;
            this.Name_Label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Name_Label.Location = new System.Drawing.Point(68, 55);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(82, 13);
            this.Name_Label.TabIndex = 2;
            this.Name_Label.Text = "Expense Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expense Cost:";
            // 
            // ExpCat_Combo
            // 
            this.ExpCat_Combo.FormattingEnabled = true;
            this.ExpCat_Combo.Items.AddRange(new object[] {
            "Entertainment",
            "Food",
            "Monthly"});
            this.ExpCat_Combo.Location = new System.Drawing.Point(156, 151);
            this.ExpCat_Combo.Name = "ExpCat_Combo";
            this.ExpCat_Combo.Size = new System.Drawing.Size(126, 21);
            this.ExpCat_Combo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expense Category:";
            // 
            // Add_Button
            // 
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Location = new System.Drawing.Point(57, 214);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(225, 52);
            this.Add_Button.TabIndex = 6;
            this.Add_Button.Text = "ADD";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Warn_Label
            // 
            this.Warn_Label.AutoSize = true;
            this.Warn_Label.ForeColor = System.Drawing.Color.Red;
            this.Warn_Label.Location = new System.Drawing.Point(98, 19);
            this.Warn_Label.Name = "Warn_Label";
            this.Warn_Label.Size = new System.Drawing.Size(0, 13);
            this.Warn_Label.TabIndex = 7;
            // 
            // Add_Exp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(487, 357);
            this.Controls.Add(this.Warn_Label);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpCat_Combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Exp_Cost_Text);
            this.Controls.Add(this.Exp_Name_Text);
            this.Name = "Add_Exp_Form";
            this.Text = "Add Expense";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Exp_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Exp_Name_Text;
        private System.Windows.Forms.TextBox Exp_Cost_Text;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ExpCat_Combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label Warn_Label;
    }
}