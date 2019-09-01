using MVaahan.RepositoryContracts.Admin;
using MVaahan.ServiceContracts.Admin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVaahan.Services.Admin
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository) {
            _loginRepository = loginRepository;
        }
        public Task<int> Login(string username, string password)
        {
            return _loginRepository.Login(username, password);
        }

        public Task<int> Register(object user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new NotImplementedException();
        }
    }
}
