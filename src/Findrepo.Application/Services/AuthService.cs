using Findrepo.Domain.Repositories;
using Findrepo.Infrastructure.Services;

namespace Findrepo.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly JwtTokenProvider _jwtTokenProvider;

        public AuthService(JwtTokenProvider jwtTokenProvider)
        {
            _jwtTokenProvider = jwtTokenProvider;
        }

        public string GenerateToken(string email)
        {
            return _jwtTokenProvider.CreateToken(email);
        }

        public bool ValidateToken(string token)
        {
            return _jwtTokenProvider.ValidateToken(token);
        }
    }
}