using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Expense_Library;
using Tracker_UI.AddRemove_Forms;
using System.Xml.Serialization;

namespace Tracker_UI.Transaction_Lists_Forms
{
    public partial class Recurring_Form : Form
    {
      
        public static Recurring_Form instance;

        Recurring_Exp Recurring_Ex = new Recurring_Exp();
        public BindingSource RecBind = new BindingSource();
        private int indexselector;

        string filepath = Path.Combine(Environment.CurrentDirectory, "Recurring-Save.xml");


        public Recurring_Form()
        {
            InitializeComponent();
            instance = this;
            ListReset();

        }

        //Total for Food Category
        public double Rec_Total()
        {
            double total = Recurring_Ex.Recurring_Expenses_List.Sum(Base_Expense => Base_Expense.Expense_Price);
            return total;

        }


        public void ListReset()
        {
            RecBind.DataSource = Recurring_Ex.Recurring_Expenses_List;
            Recurring_List.DataSource = RecBind;
           Recurring_List.DisplayMember = "Display";
            Recurring_List.ValueMember = "Display";
            RecBind.ResetBindings(false);
        }



        public void AddRecExp()
        {
            Recurring_Ex.Recurring_Expenses_List.Add(new Base_Expense { Expense_Name = Add_Exp_Form.instance.namebox.Text, Expense_Price = Convert.ToDouble(Add_Exp_Form.instance.costbox.Text) });
            RecBind.ResetBindings(false);
            Expense_Tracker_Form.instance.Chart_initializer();
        }


        private void Recurring_List_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Remove_Exp_Form remer = new Remove_Exp_Form();
            indexselector = this.Recurring_List.IndexFromPoint(e.Location);
            remer.ShowDialog();
        }


        public void Remove_Food_Exp()
        {
            Recurring_Ex.Recurring_Expenses_List.RemoveAt(indexselector);
            RecBind.ResetBindings(false);
            Expense_Tracker_Form.instance.Chart_initializer();
        }

        public void Serializer()
        {
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Recurring_Exp));
            using (TextWriter tw = new StreamWriter(filepath))
            {
                serializer.Serialize(tw, Recurring_Ex);
            }
        }

        public void DeSerializer()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Recurring_Exp));

            if (File.Exists(filepath))
            {
                TextReader reader = new StreamReader(filepath);
                object obj = deserializer.Deserialize(reader);
                Recurring_Ex = (Recurring_Exp)obj;
                reader.Close();

                ListReset();

            }

        }

   
    }
}
