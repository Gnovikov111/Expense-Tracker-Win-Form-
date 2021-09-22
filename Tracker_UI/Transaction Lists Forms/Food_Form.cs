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
    public partial class Food_Form : Form
    {
        public static Food_Form instance;

        Food_Expenses FoodExp = new Food_Expenses();
        public BindingSource FoodBind = new BindingSource();
        private int indexselector;

        string filepath = Path.Combine(Environment.CurrentDirectory, "FOOD-Save.xml");


        public Food_Form()
        {
            InitializeComponent();
            instance = this;
            ListReset();
         
        }

        //Total for Food Category
        public double Food_Total()
        {
            double total = FoodExp.Food_Expenses_List.Sum(Base_Expense => Base_Expense.Expense_Price);

            return total;

        }


        public void ListReset()
        {
            FoodBind.DataSource = FoodExp.Food_Expenses_List;
            Food_List.DataSource = FoodBind;
            Food_List.DisplayMember = "Display";
            Food_List.ValueMember = "Display";
            FoodBind.ResetBindings(false);
        }



        public void AddFoodExp()
        {
            FoodExp.Food_Expenses_List.Add(new Base_Expense { Expense_Name = Add_Exp_Form.instance.namebox.Text, Expense_Price = Convert.ToDouble(Add_Exp_Form.instance.costbox.Text) });
            FoodBind.ResetBindings(false);
            Expense_Tracker_Form.instance.Chart_initializer();
        }

        private void Food_List_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Remove_Exp_Form rem = new Remove_Exp_Form();
            indexselector = this.Food_List.IndexFromPoint(e.Location);
            rem.ShowDialog();
        }


        public void Remove_Food_Exp()
        {
            FoodExp.Food_Expenses_List.RemoveAt(indexselector);
            FoodBind.ResetBindings(false);
            Expense_Tracker_Form.instance.Chart_initializer();
        }

        public void Serializer()
        {
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Food_Expenses));
            using (TextWriter tw = new StreamWriter(filepath))
            {
                serializer.Serialize(tw, FoodExp);
            }
        }

        public void DeSerializer()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Food_Expenses));

            if (File.Exists(filepath))
            {
                TextReader reader = new StreamReader(filepath);
                object obj = deserializer.Deserialize(reader);
                FoodExp = (Food_Expenses)obj;
                reader.Close();

                ListReset();

            }

        }



    }
}
