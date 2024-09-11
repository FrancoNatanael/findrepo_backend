namespace Findrepo.Domain.Repositories
{
    public interface IAuthService
    {
        string GenerateToken(string email);
        bool ValidateToken(string token);
    }
}
