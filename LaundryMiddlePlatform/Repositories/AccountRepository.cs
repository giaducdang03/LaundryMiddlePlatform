﻿using BusinessObjects.Models;
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

        public Account GetAccountById(int id)
            => AccountDAO.Instance.GetAccountById(id);

        public List<Account> GetAllAccount(string? txtSearch, string? role, string? sortType)
            => AccountDAO.Instance.GetAllAccounts(txtSearch, role, sortType);

        public bool ResetPassword(Account account)
            => AccountDAO.Instance.ResetPassword(account);

        public bool SaveAccount(Account account)
        {
            if (!AccountValidation.IsValidEmail(account.Email))
            {
                throw new Exception("Email is invalid. Ex. example@email.com");
            }
            if (!AccountValidation.CheckString(account.FullName, 4, 50))
            {
                throw new Exception("Full name must be 4 to 50 characters");
            }
            if (!AccountValidation.CheckString(account.Address, 4, 50))
            {
                throw new Exception("Address must be 4 to 50 characters");
            }
            return AccountDAO.Instance.SaveAccount(account);
        }

        public bool UpdateAccount(Account account)
        {
            if (!AccountValidation.IsValidEmail(account.Email))
            {
                throw new Exception("Email is invalid. Ex. example@email.com");
            }
            if (!AccountValidation.CheckString(account.FullName, 4, 50))
            {
                throw new Exception("Full name must be 4 to 50 characters");
            }
            if (!AccountValidation.CheckString(account.Address, 4, 50))
            {
                throw new Exception("Address must be 4 to 50 characters");
            }
            return AccountDAO.Instance.UpdateAccount(account);
        }
    }
}
