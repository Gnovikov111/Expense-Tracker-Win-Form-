using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Expense_Library
{


    [Serializable()]
    public class Food_Expenses : ISerializable
    {
        public List<Base_Expense> Food_Expenses_List { get; set; }
        public string Expense_Type { get; set; }

        public Food_Expenses()
        {
            Food_Expenses_List = new List<Base_Expense>();
            this.Expense_Type = "Entertainment";

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Food_Expenses_List", Food_Expenses_List);
            info.AddValue("Expense_Type", Expense_Type);
        }
        public Food_Expenses(SerializationInfo info, StreamingContext context)
        {
            Food_Expenses_List = (List<Base_Expense>)info.GetValue("Food_Expenses_List", typeof(List<Base_Expense>));
            Expense_Type = (string)info.GetValue("Expense_Type", typeof(string));

        }
    }
}
