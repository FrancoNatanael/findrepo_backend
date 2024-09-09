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
            var user = (from userDb in _context.User
                        where userDb.Email.Equals(email)
                        select userDb).ToList();

            return user.FirstOrDefault();
        }
    }
}
