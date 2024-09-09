using Findrepo.Domain.Entities.User;

namespace Findrepo.Domain.Repositories
{
    public interface IUserRepository
    {
        public void CreateUser(User user);
        public User GetUser(string email);
    }
}