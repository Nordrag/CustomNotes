using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CustomNotes
{
    public class SearchService
    {
        private ApplicationDbContext mContext;

        public SearchService(ApplicationDbContext context)
        {
            mContext = context;
        }

        public ObservableCollection<CashDiffModel> GetDifferences()
        {
            var result = mContext.DailyCash.ToList();
            ObservableCollection<CashDiffModel> value = new ObservableCollection<CashDiffModel>();
            result.ForEach(r => value.Add(new CashDiffModel 
            {
                Id = r.Id,
                Difference = r.Difference,
                PostedBy = r.PostedBy,
                Date = r.Date.ToString("dd/MM/yyyy")
            }));

            return value;
        }
    }
}
