using System;
using System.Collections.Generic;
using System.Text;

namespace CustomNotes
{
    public class CustomModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; } = "Emlékeztetőnek";
        public string Relevance { get; set; } = "Új";
        public string CustomTag { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
