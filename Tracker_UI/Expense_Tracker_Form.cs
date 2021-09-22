using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tracker_UI.Transaction_Lists;
using Tracker_UI.Transaction_Lists_Forms;

namespace Tracker_UI
{
    public partial class Expense_Tracker_Form : Form
    {

        private bool mouseDown;
        private Point lastLocation;
       
        public static Expense_Tracker_Form instance;
        public Label total_label;
        public ComboBox list_reference;

        Entertain_Form entform = new Entertain_Form();
        Food_Form foodform = new Food_Form();
        Recurring_Form recform = new Recurring_Form();


        public Expense_Tracker_Form()
        {
            InitializeComponent();
            instance = this;
            List_Combx.SelectedIndex = 0;
            list_reference = List_Combx;
            Display_Lists();

         //Loading in Serialized Objects
          Entertain_Form.instance.DeSerializer();
          Food_Form.instance.DeSerializer();
            Recurring_Form.instance.DeSerializer();

            Chart_initializer();


        }

        private void Display_Lists()
        {

            //Entertainment List Switch
            if (List_Combx.SelectedIndex == 0)
            {
                Trans_Panel.Controls.Clear();
                entform.TopLevel = false;
                entform.AutoScroll = true;

                Trans_Panel.Controls.Add(entform);
                entform.Show();

            }

            // Food List Switch
            if (List_Combx.SelectedIndex == 1)
            {
                Trans_Panel.Controls.Clear();
                foodform.TopLevel = false;
                foodform.AutoScroll = true;

                Trans_Panel.Controls.Add(foodform);
                foodform.Show();

            }

            // Recurring Expenses Switch
            if (List_Combx.SelectedIndex == 2)
            {
                Trans_Panel.Controls.Clear();
                recform.TopLevel = false;
                recform.AutoScroll = true;

                Trans_Panel.Controls.Add(recform);
                recform.Show();

            }


        }

        // Form Movement Start
        private void Expense_Tracker_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Expense_Tracker_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Expense_Tracker_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //Form Movement End


        private void AddExp_Button_Click(object sender, EventArgs e)
        {
            Add_Exp_Form expform = new Add_Exp_Form();
            expform.ShowDialog();
        }


        private void List_Combx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Lists();

        }


        private void Close_Button_MouseEnter(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.Red;
        }

        private void Close_Button_MouseLeave(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.White;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            // Serialzation for all lists
            Entertain_Form.instance.Serializer();
            Food_Form.instance.Serializer();
            Recurring_Form.instance.Serializer();
            Environment.Exit(0);
        }

        private void Min_Button_MouseEnter(object sender, EventArgs e)
        {
            Min_Button.ForeColor = Color.FromArgb(0, 122, 204);
        }

        private void Min_Button_MouseLeave(object sender, EventArgs e)
        {
            Min_Button.ForeColor = Color.White;
        }

        private void Min_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Expense_Tracker_Form_Load(object sender, EventArgs e)
        {
          


        }

        public void Total_Updater()
        {
            double total = Recurring_Form.instance.Rec_Total() + Food_Form.instance.Food_Total() + Entertain_Form.instance.Ent_Total();

            Expense_Total_Label.Text = "Total Expenses: "  + "$" + total.ToString();


        }



        public void Chart_initializer()
        {
           
            Expenses_Pie.LegendLocation = LegendLocation.Bottom;
            Total_Updater();

            
            
            Expenses_Pie.Series =  new LiveCharts.SeriesCollection
            {
                new PieSeries
                {
                    Title = "Entertainment",
                    Values = new ChartValues<double> {Entertain_Form.instance.Ent_Total()},
                    DataLabels = true,
                    

                },
                new PieSeries
                {
                    Title = "Food",
                    Values= new ChartValues<double> {Food_Form.instance.Food_Total()},
                    DataLabels = true

                },
                new PieSeries
                {
                    Title = "Monthly Recurring",
                    Values= new ChartValues<double> {Recurring_Form.instance.Rec_Total()},
                    DataLabels = true

                }


            };


        }
    }
}
