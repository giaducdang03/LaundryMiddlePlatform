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

        public bool SaveAccount(Account account)
        {
            if (!AccountValidation.IsValidEmail(account.Email))
            {
                throw new Exception("Your email is invalid. Ex. example@email.com");
            }
            return AccountDAO.Instance.SaveAccount(account);
        }
    }
}
