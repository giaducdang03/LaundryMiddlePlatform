using BusinessObjects.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public int GetAccountIdbyEmail(string txtMail)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                
                Account account =  db.Accounts.SingleOrDefault(a => a.Email == txtMail);
                return account.AccountId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<Account> getAccountStoreRole()
        {
            List<Account> accounts = new List<Account>();
            try
            {
                using var db = new LaundryManagementPrnContext();
                var query = db.Accounts.Where(p => p.Role == "Store" && p.Store == null).ToList();
                accounts = query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return accounts;
        }
        public int getAccountbyName(string Name)
        {

            try
            {
                using var db = new LaundryManagementPrnContext();

                Account account = db.Accounts.SingleOrDefault(a => a.FullName == Name);
                return account.AccountId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<Account> GetAllAccounts(string? txtSearch, string? role, string? sortType)
        {
            List<Account> accounts = new List<Account>();
            try
            {
                using var db = new LaundryManagementPrnContext();
                var query = db.Accounts.Where(a => a.Status == true).AsQueryable();

                // sort and filter
                if (!string.IsNullOrEmpty(txtSearch.Trim()))
                {
                    //query = query.Where(a => a.FullName.ToLower().Contains(txtSearch.ToLower()));
                    query = query.Where(delegate (Account c)
                    {
                        if (ConvertToUnSign(c.FullName.ToLower()).IndexOf(txtSearch.ToLower(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                            return true;
                        else
                            return false;
                    }).AsQueryable();
                }
                if (!string.IsNullOrEmpty(role) && role != "All")
                {
                    query = query.Where(a => a.Role == role);
                }
                if (!string.IsNullOrEmpty(sortType))
                {
                    if (sortType == "Name: A -> Z")
                    {
                        query = query.OrderBy(a => a.FullName);
                    }
                    if (sortType == "Name: Z -> A")
                    {
                        query = query.OrderByDescending(a => a.FullName);
                    }
                }
                if (!query.Any())
                {
                    throw new Exception("Not found.");
                }

                accounts = query.ToList();

                return accounts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateAccount(Account account)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.Accounts.Update(account);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteAccount(Account account)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var updateAccount = db.Accounts.SingleOrDefault(a => a.AccountId == account.AccountId);
                if (updateAccount != null)
                {
                    updateAccount.Status = false; 
                    db.Accounts.Update(updateAccount);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ResetPassword(Account account)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var updateAccount = db.Accounts.SingleOrDefault(a => a.AccountId == account.AccountId);
                if (updateAccount != null)
                {
                    updateAccount.Password = "1";
                    db.Accounts.Update(updateAccount);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account GetAccountById(int accountId)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                return db.Accounts.SingleOrDefault(a => a.AccountId == accountId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Account> GetStaff()
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                return db.Accounts.Where(a => a.Role == "Staff").ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string ConvertToUnSign(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            return str2;
        }
    }
}
