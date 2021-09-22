using System;
using System.Windows.Forms;
using Tracker_UI.Transaction_Lists;
using Tracker_UI.Transaction_Lists_Forms;

namespace Tracker_UI.AddRemove_Forms
{
    public partial class Remove_Exp_Form : Form
    {
        public Remove_Exp_Form()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void Yes_Button_Click(object sender, EventArgs e)
        {
            if (Expense_Tracker_Form.instance.list_reference.SelectedIndex == 0)
            {
                Entertain_Form.instance.Remove_Ent_Exp();
            }
            if (Expense_Tracker_Form.instance.list_reference.SelectedIndex == 1)
            {
                Food_Form.instance.Remove_Food_Exp();
            }
            if (Expense_Tracker_Form.instance.list_reference.SelectedIndex == 2)
            {
                Recurring_Form.instance.Remove_Food_Exp();
            }

            this.Close();
        }

        private void No_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
