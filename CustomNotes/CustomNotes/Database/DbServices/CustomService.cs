using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomNotes
{
    public class CustomService
    {
        private ApplicationDbContext mContext;

        public CustomService(ApplicationDbContext context)
        {
            mContext = context;
        }

        public void AddTag(CustomTag tag)
        {
            mContext.CustomTag.Add(tag);
            mContext.SaveChanges();
        }

        public bool CheckIfTagExists(CustomTag tag)
        {
            return mContext.CustomTag.Where(r => r.Tag == tag.Tag).Any();
        }
    }
}
