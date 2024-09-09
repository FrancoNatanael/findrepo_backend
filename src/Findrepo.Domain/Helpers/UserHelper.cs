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
            try
            {
                User user = new User()
                {
                    Email = email,
                    LastName = lastName,
                    Name = firstName,
                    Password = password,
                };

                _userRepository.CreateUser(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User GetUser(string email)
        {
            return _userRepository.GetUser(email);
        }
    }
}
