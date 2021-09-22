using System;

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

        public string Display
        {
            get
            {
                return string.Format("{0} - ${1} - {2}", Expense_Name, Expense_Price, Expense_Time);
            }


        }

    }






}
