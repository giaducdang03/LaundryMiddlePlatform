using BusinessObjects.Models;
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
    }
}
