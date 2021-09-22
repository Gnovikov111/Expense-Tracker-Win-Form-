using System;
using System.Windows.Forms;
using Tracker_UI.Transaction_Lists;
using Tracker_UI.Transaction_Lists_Forms;

namespace Tracker_UI
{
    public partial class Add_Exp_Form : Form
    {

        public static Add_Exp_Form instance;
        public TextBox namebox;
        public TextBox costbox;



        public Add_Exp_Form()
        {
            InitializeComponent();
            instance = this;
            namebox = Exp_Name_Text;
            costbox = Exp_Cost_Text;
            ExpCat_Combo.SelectedIndex = 0;
            this.CenterToParent();

        }



        private void Add_Button_Click(object sender, EventArgs e)
        {
            double output = 0;

            // Error catching for not inputting a number cost
            if (double.TryParse(Exp_Cost_Text.Text, out output))
            {

                Warn_Label.Text = "";

                // Entertainment
                if (ExpCat_Combo.SelectedIndex == 0)
                {
                    Entertain_Form.instance.AddEntExp();

                }
                // Food
                if (ExpCat_Combo.SelectedIndex == 1)
                {
                    Food_Form.instance.AddFoodExp();
                }
                //Monthly
                if(ExpCat_Combo.SelectedIndex == 2)
                {
                    Recurring_Form.instance.AddRecExp();
                }

            }
            else
            {
                Console.WriteLine("Not a numerical value");
                Warn_Label.Text = "* Enter a valid cost";
            }

        }

        private void Add_Exp_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
