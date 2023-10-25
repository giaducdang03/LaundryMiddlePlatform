﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAccountRepository 
    {
        Account CheckLogin(string email, string password);
        bool SaveAccount(Account account);
        List<Account> GetAllAccount(string? txtSearch, string? role, string? sortType);
        bool UpdateAccount(Account account);
        bool DeleteAccount(Account account);
        bool ResetPassword(Account account);
        Account GetAccountById(int id);
    }
}
