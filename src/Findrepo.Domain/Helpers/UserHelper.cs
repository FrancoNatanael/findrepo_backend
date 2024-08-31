using Findrepo.Domain.Repositories;

namespace Findrepo.Domain.Helpers
{
    public class UserHelper
    {
        private IUserRepository _userRepository;

        public UserHelper(IUserRepository userRepository) 
        {
            userRepository = _userRepository;
        }

        public void CreateUser(string firstName, string lastName, string password, string email)
        {
            _userRepository.CreateUser(firstName, lastName, password, email);
        }
    }
}
