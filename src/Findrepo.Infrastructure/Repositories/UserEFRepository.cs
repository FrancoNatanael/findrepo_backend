using Findrepo.Domain.Entities.User;
using Findrepo.Domain.Repositories;
using Findrepo.Infrastructure.Context;

namespace Findrepo.Infrastructure.Repositories
{
    public class UserEFRepository : IUserRepository
    {
        private FindrepoContext _context;

        public UserEFRepository(FindrepoContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public User GetUser(string email)
        {
            return  _context.User.FirstOrDefault(userDb => userDb.Email == email);
        }
    }
}
