using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AccountDAO
    {
        public static AccountDAO instance = null;
        public static object lockObject = new Object();

        private AccountDAO() { }

        public static AccountDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                }
                return instance;
            }
        }

        public Account CheckLogin(string email, string password)
        {
            using var db = new LaundryManagementPrnContext();
            return db.Accounts.SingleOrDefault(a => a.Status == true && a.Email == email && a.Password == password);
        }

        public bool SaveAccount(Account account)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var userExist = db.Accounts.SingleOrDefault(a => a.Email == account.Email);
                if (userExist != null)
                {
                    throw new Exception("Email is exist. Please change email or contact administrator");
                }
                db.Accounts.Add(account);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
