namespace Tracker_UI
{
    partial class Expense_Tracker_Form
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
            this.AddExp_Button = new System.Windows.Forms.Button();
            this.Trans_Panel = new System.Windows.Forms.Panel();
            this.List_Combx = new System.Windows.Forms.ComboBox();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Min_Button = new System.Windows.Forms.Button();
            this.Expenses_Pie = new LiveCharts.WinForms.PieChart();
            this.Expense_Total_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddExp_Button
            // 
            this.AddExp_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddExp_Button.ForeColor = System.Drawing.Color.White;
            this.AddExp_Button.Location = new System.Drawing.Point(479, 487);
            this.AddExp_Button.Name = "AddExp_Button";
            this.AddExp_Button.Size = new System.Drawing.Size(218, 40);
            this.AddExp_Button.TabIndex = 0;
            this.AddExp_Button.Text = "Add Expense";
            this.AddExp_Button.UseVisualStyleBackColor = true;
            this.AddExp_Button.Click += new System.EventHandler(this.AddExp_Button_Click);
            // 
            // Trans_Panel
            // 
            this.Trans_Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_Panel.Location = new System.Drawing.Point(479, 97);
            this.Trans_Panel.Name = "Trans_Panel";
            this.Trans_Panel.Size = new System.Drawing.Size(466, 370);
            this.Trans_Panel.TabIndex = 6;
            // 
            // List_Combx
            // 
            this.List_Combx.FormattingEnabled = true;
            this.List_Combx.Items.AddRange(new object[] {
            "Entertainment",
            "Food",
            "Monthly"});
            this.List_Combx.Location = new System.Drawing.Point(479, 70);
            this.List_Combx.Name = "List_Combx";
            this.List_Combx.Size = new System.Drawing.Size(121, 21);
            this.List_Combx.TabIndex = 7;
            this.List_Combx.SelectedIndexChanged += new System.EventHandler(this.List_Combx_SelectedIndexChanged);
            // 
            // Close_Button
            // 
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.ForeColor = System.Drawing.Color.White;
            this.Close_Button.Location = new System.Drawing.Point(971, 12);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(27, 23);
            this.Close_Button.TabIndex = 10;
            this.Close_Button.Text = "X";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            this.Close_Button.MouseEnter += new System.EventHandler(this.Close_Button_MouseEnter);
            this.Close_Button.MouseLeave += new System.EventHandler(this.Close_Button_MouseLeave);
            // 
            // Min_Button
            // 
            this.Min_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min_Button.ForeColor = System.Drawing.Color.White;
            this.Min_Button.Location = new System.Drawing.Point(938, 12);
            this.Min_Button.Name = "Min_Button";
            this.Min_Button.Size = new System.Drawing.Size(27, 23);
            this.Min_Button.TabIndex = 11;
            this.Min_Button.Text = "-";
            this.Min_Button.UseVisualStyleBackColor = true;
            this.Min_Button.Click += new System.EventHandler(this.Min_Button_Click);
            this.Min_Button.MouseEnter += new System.EventHandler(this.Min_Button_MouseEnter);
            this.Min_Button.MouseLeave += new System.EventHandler(this.Min_Button_MouseLeave);
            // 
            // Expenses_Pie
            // 
            this.Expenses_Pie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Expenses_Pie.ForeColor = System.Drawing.Color.White;
            this.Expenses_Pie.Location = new System.Drawing.Point(12, 146);
            this.Expenses_Pie.Name = "Expenses_Pie";
            this.Expenses_Pie.Size = new System.Drawing.Size(449, 355);
            this.Expenses_Pie.TabIndex = 12;
            this.Expenses_Pie.Text = "pieChart1";
            // 
            // Expense_Total_Label
            // 
            this.Expense_Total_Label.AutoSize = true;
            this.Expense_Total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Total_Label.ForeColor = System.Drawing.Color.White;
            this.Expense_Total_Label.Location = new System.Drawing.Point(5, 55);
            this.Expense_Total_Label.Name = "Expense_Total_Label";
            this.Expense_Total_Label.Size = new System.Drawing.Size(89, 37);
            this.Expense_Total_Label.TabIndex = 13;
            this.Expense_Total_Label.Text = "Total";
            // 
            // Expense_Tracker_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1010, 575);
            this.Controls.Add(this.Expense_Total_Label);
            this.Controls.Add(this.Expenses_Pie);
            this.Controls.Add(this.Min_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.List_Combx);
            this.Controls.Add(this.Trans_Panel);
            this.Controls.Add(this.AddExp_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expense_Tracker_Form";
            this.Text = "Expense Tracker";
            this.Load += new System.EventHandler(this.Expense_Tracker_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Expense_Tracker_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Expense_Tracker_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Expense_Tracker_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddExp_Button;
        private System.Windows.Forms.Panel Trans_Panel;
        private System.Windows.Forms.ComboBox List_Combx;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Min_Button;
        private LiveCharts.WinForms.PieChart Expenses_Pie;
        private System.Windows.Forms.Label Expense_Total_Label;
    }
}

