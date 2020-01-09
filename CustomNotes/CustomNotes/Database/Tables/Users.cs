using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomNotes
{
    public class Users
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<CashDiff> PostedDiffs { get; set; }
        public List<CustomTable> CreatedTables { get; set; }
    }
}
