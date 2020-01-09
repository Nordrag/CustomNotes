using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomNotes
{
    public class CustomTag
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Tag { get; set; }
        public List<CustomTable> CustomTables { get; set; } = new List<CustomTable>();
    }
}
