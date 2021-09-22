using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Expense_Library
{

    [Serializable()]
    public class Entertainment_Expenses : ISerializable
    {

        public List<Base_Expense> Ent_Expenses { get; set; }
        public string Expense_Type { get; set; }


        public Entertainment_Expenses()
        {
            Ent_Expenses = new List<Base_Expense>();
            this.Expense_Type = "Entertainment";

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Ent_Expense", Ent_Expenses);
            info.AddValue("Expense_Type", Expense_Type);
        }

        public Entertainment_Expenses(SerializationInfo info, StreamingContext context)
        {
            Ent_Expenses = (List<Base_Expense>)info.GetValue("Ent_Expense", typeof(List<Base_Expense>));
            Expense_Type = (string)info.GetValue("Expense_Type", typeof(string));
        }
    }
}
