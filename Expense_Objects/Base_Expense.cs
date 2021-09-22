using System;
using System.Collections.Generic;
using System.Text;

namespace Expense_Library
{
    public class Base_Expense
    {
        public string Expense_Name { get; set; }
        public double Expense_Price { get; set; }
        public DateTime Expense_Time { get; set; }

        public Base_Expense()
        {
            this.Expense_Time = DateTime.Now;

        }
    }
}
