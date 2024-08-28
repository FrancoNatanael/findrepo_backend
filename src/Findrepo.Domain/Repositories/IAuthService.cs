using Findrepo.Domain.Entities.User;

namespace Findrepo.Domain.Repositories
{
    public interface IAuthService
    {
        string GenerateToken(User user);
        bool ValidateToken(string token);
    }
}
