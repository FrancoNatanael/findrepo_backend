namespace Findrepo.Domain.Repositories
{
    public interface IUserRepository
    {
        public void CreateUser(string firstName, string lastName, string password, string email);
    }
}