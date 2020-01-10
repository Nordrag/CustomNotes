using System;
using System.Collections.Generic;
using System.Text;

namespace CustomNotes
{
    public class Services
    {
        public static ApplicationDbContext Context { get; set; } = new ApplicationDbContext();

        public CashDiffServices CashDiffServices { get; set; } = new CashDiffServices(Context);
        public SearchService SearchService { get; set; } = new SearchService(Context);
        public AccountService AccountService { get; set; } = new AccountService(Context);
        public CustomService CustomService { get; set; } = new CustomService(Context);

    }
}
