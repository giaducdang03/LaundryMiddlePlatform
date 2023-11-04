using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Validation;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public Account CheckLogin(string email, string password)
            => AccountDAO.Instance.CheckLogin(email, password);

        public bool DeleteAccount(Account account)
            => AccountDAO.Instance.DeleteAccount(account);
        public List<Account> GetAccountWithoutInfo()
            => AccountDAO.Instance.getAccountStoreRole();
        
        public int GetAccountIdByEmail(string email) 
            => AccountDAO.Instance.GetAccountIdbyEmail(email);
        public int GetAccountByName(string name)
            => AccountDAO.Instance.getAccountbyName(name);
        public Account GetAccountById(int id)
            => AccountDAO.Instance.GetAccountById(id);

        public List<Account> GetAllAccount(string? txtSearch, string? role, string? sortType)
            => AccountDAO.Instance.GetAllAccounts(txtSearch, role, sortType);

        public bool ResetPassword(Account account)
            => AccountDAO.Instance.ResetPassword(account);

        public bool SaveAccount(Account account)
        {
            if (!CommonValidation.IsValidEmail(account.Email))
            {
                throw new Exception("Email is invalid. Ex. example@email.com");
            }
            if (!CommonValidation.CheckString(account.FullName, 4, 50))
            {
                throw new Exception("Full name must be 4 to 50 characters");
            }
            if (!CommonValidation.CheckString(account.Address, 4, 50))
            {
                throw new Exception("Address must be 4 to 50 characters");
            }
            if (!CommonValidation.CheckPhoneNumber(account.PhoneNumber))
            {
                throw new Exception("Phone number is invalid. Ex: 0123456789");
            }
            return AccountDAO.Instance.SaveAccount(account);
        }

        public bool UpdateAccount(Account account)
        {
            if (!CommonValidation.IsValidEmail(account.Email))
            {
                throw new Exception("Email is invalid. Ex. example@email.com");
            }
            if (!CommonValidation.CheckString(account.FullName, 4, 50))
            {
                throw new Exception("Full name must be 4 to 50 characters");
            }
            if (!CommonValidation.CheckString(account.Address, 4, 50))
            {
                throw new Exception("Address must be 4 to 50 characters");
            }
            if (!CommonValidation.CheckPhoneNumber(account.PhoneNumber))
            {
                throw new Exception("Phone number is invalid. Ex: 0123456789");
            }
            return AccountDAO.Instance.UpdateAccount(account);
        }

        public List<Account> GetStaff()
            => AccountDAO.Instance.GetStaff();
    }
}
