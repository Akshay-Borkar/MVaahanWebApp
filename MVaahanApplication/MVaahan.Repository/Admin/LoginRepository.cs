using MVaahan.DomainEntities.Admin;
using MVaahan.RepositoryContracts.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVaahan.Repository.Admin
{
    public class LoginRepository : ILoginRepository
    {

        private readonly MVaahanDataContext _context;
        public LoginRepository(MVaahanDataContext context) {
            _context = context;
        }
        public async Task<int> Login(string username, string password)
        {
            var user = _context.Users.Where(x => x.Id == 1).FirstOrDefault();
            return 1;
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
