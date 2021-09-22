using Expense_Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tracker_UI.AddRemove_Forms;

namespace Tracker_UI.Transaction_Lists
{
    public partial class Entertain_Form : Form
    {
        public static Entertain_Form instance;



        Entertainment_Expenses ent = new Entertainment_Expenses();
        public BindingSource EntertainBind = new BindingSource();
        private int indexselector;

        string filepath = Path.Combine(Environment.CurrentDirectory, "ENT-Save.xml");

    
        public Entertain_Form()
        {
            InitializeComponent();
            instance = this;
            ListReset();
          
        }

        public double Ent_Total()
        {
            double total = ent.Ent_Expenses.Sum(Base_Expense => Base_Expense.Expense_Price);

            return total;

        }

        public void ListReset()
        {
            EntertainBind.DataSource = ent.Ent_Expenses;
            Entertain_List.DataSource = EntertainBind;

            Entertain_List.DisplayMember = "Display";
            Entertain_List.ValueMember = "Display";

            EntertainBind.ResetBindings(false);


        }

        public void AddEntExp()
        {
           
            ent.Ent_Expenses.Add(new Base_Expense { Expense_Name = Add_Exp_Form.instance.namebox.Text, Expense_Price = Convert.ToDouble(Add_Exp_Form.instance.costbox.Text) });
            EntertainBind.ResetBindings(false);
            Expense_Tracker_Form.instance.Chart_initializer();
        }

        private void Entertain_List_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Remove_Exp_Form rem = new Remove_Exp_Form();
            indexselector = this.Entertain_List.IndexFromPoint(e.Location);
            rem.ShowDialog();

        }

        public void Remove_Ent_Exp()
        {
            if(ent.Ent_Expenses.Count > 0)
            {
                ent.Ent_Expenses.RemoveAt(indexselector);
                EntertainBind.ResetBindings(false);
            }
            Expense_Tracker_Form.instance.Chart_initializer();
        }

        public void Serializer()
        {
           
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
           
            XmlSerializer serializer = new XmlSerializer(typeof(Entertainment_Expenses));
            using (TextWriter tw = new StreamWriter(filepath))
            {
                serializer.Serialize(tw, ent);
            }
        }

        public void DeSerializer()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Entertainment_Expenses));

            if (File.Exists(filepath))
            {
                TextReader reader = new StreamReader(filepath);
                object obj = deserializer.Deserialize(reader);
                ent = (Entertainment_Expenses)obj;
                reader.Close();

                ListReset();

            }
     
        }

    }
}
