using System;
using System.Collections.Generic;
using System.Text;

namespace CustomNotes
{
    public class Services
    {
        private static ApplicationDbContext Context { get; set; } = new ApplicationDbContext();

        public CashDiffServices CashDiffServices { get; set; } = new CashDiffServices(Context);
        public SearchService SearchService { get; set; } = new SearchService(Context);
    }
}
