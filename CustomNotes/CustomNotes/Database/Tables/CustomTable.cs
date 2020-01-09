﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomNotes
{
    public class CustomTable
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Users PostedBy { get; set; }
        public CustomTag Tags { get; set; }
    }
}