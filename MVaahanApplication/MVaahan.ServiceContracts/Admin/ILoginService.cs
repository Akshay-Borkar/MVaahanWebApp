using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVaahan.ServiceContracts.Admin
{
    public interface ILoginService
    {
        Task<int> Register(Object user, string password);
        Task<int> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
