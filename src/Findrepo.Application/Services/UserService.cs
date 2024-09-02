using Findrepo.Application.DTOS;
using Findrepo.Domain.Entities.User;
using Findrepo.Domain.Helpers;

namespace Findrepo.Application.Services
{
    public class UserService
    {
        private UserHelper _userHelper;

        public UserService(UserHelper userHelper)
        {
            _userHelper = userHelper;
        }

        public UserDTO GetUserDTO(string email)
        {
            User user = _userHelper.GetUser(email);

            return new UserDTO
            {
                Email = user.Email,
                FirtsName = user.Name,
                LastName = user.LastName,
                Password = user.Password,
            };
        }
    }
}
