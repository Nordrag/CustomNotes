using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomNotes
{
    public class AccountService
    {
        private ApplicationDbContext mContext;

        public AccountService(ApplicationDbContext context)
        {
            mContext = context;
        }

        public bool CheckIfExist(string username)
        {
            var result = mContext.Users.Where(r => r.Username == username).Any();
            return result;
        }

        public void RegUser(Users users)
        {
            mContext.Users.Add(users);
            mContext.SaveChanges();
        }
        
        public bool LoginUser(string userName, string password)
        {
            var result = mContext.Users.Where(r => r.Username == userName && r.Password == password).Any();
            return result;
        }
    }
}
