using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomNotes
{
    public class CashDiff
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public int Difference { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string PostedBy { get; set; }

    }
}
