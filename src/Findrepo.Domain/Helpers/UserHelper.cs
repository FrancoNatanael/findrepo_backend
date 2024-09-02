using Findrepo.Domain.Entities.User;
using Findrepo.Domain.Repositories;

namespace Findrepo.Domain.Helpers
{
    public class UserHelper
    {
        private IUserRepository _userRepository;

        public UserHelper(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public void CreateUser(string firstName, string lastName, string password, string email)
        {
            _userRepository.CreateUser(firstName, lastName, password, email);
        }

        public User GetUser(string email)
        {
            return _userRepository.GetUser(email);
        }
    }
}
