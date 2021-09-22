using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Library
{

    [Serializable()]
    public class Recurring_Exp: ISerializable
    {
        public List<Base_Expense> Recurring_Expenses_List { get; set; }
        public DateTime Recurring_Date { get; set; }
        public string Expense_Type { get; set; }

        public Recurring_Exp()
        {
            Recurring_Expenses_List = new List<Base_Expense>();
            this.Recurring_Date = DateTime.Now.AddMonths(1);

        }

      
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Recurring_Expense", Recurring_Expenses_List);
            info.AddValue("Recurring_Date", Recurring_Date);
        }

        public Recurring_Exp(SerializationInfo info, StreamingContext context)
        {
            Recurring_Expenses_List = (List<Base_Expense>)info.GetValue("Recurring_Expenses_List", typeof(List<Base_Expense>));
            Expense_Type = (string)info.GetValue("Expense_Type", typeof(string));

        }
    }
}
