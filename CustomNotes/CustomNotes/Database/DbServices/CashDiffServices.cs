using System;
using System.Collections.Generic;
using System.Text;

namespace CustomNotes
{
    public class CashDiffServices
    {
        private ApplicationDbContext mContext;

        public CashDiffServices(ApplicationDbContext context)
        {
            mContext = context;
        }

        public void Add(CashDiff difference)
        {
            mContext.DailyCash.Add(difference);
            mContext.SaveChanges();
        }
    }
}
