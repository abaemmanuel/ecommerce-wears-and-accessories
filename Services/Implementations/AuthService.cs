using ECommerce.Models;
using ECommerce.Utilities;
using Repository;
using System.Threading.Tasks;

namespace ECommerce.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUtilities _utility;


        public AuthService(IUserRepository users, IUtilities utilities)
        {
            _userRepository = users;
            _utility = utilities;
        }
        public async Task<User> Login(string email, string password)
        {
            string hashPassword = _utility.ComputeSha256Hash(password);
            var users = await _userRepository.GetAllUsers();
            foreach (var item in users)
            {
                if (item.Email == email && item.Password == hashPassword)
                {
                    return item;
                }

            }

            return null;

        }
    }
}
