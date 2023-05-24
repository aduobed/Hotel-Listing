using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoBank
{
    public class Transaction
    {
        public Transaction(decimal amount, DateTime date, string notes)
        {
            Amount = amount;
            Date = date;
            Notes = notes;
        }

        public decimal Amount { get; }
        public DateTime Date { get;}
        public string Notes { get; }
    }
}
