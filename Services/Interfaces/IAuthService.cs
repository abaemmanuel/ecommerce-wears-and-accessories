using ECommerce.Models;
using System.Threading.Tasks;

namespace ECommerce.Services.Implementations
{
    public interface IAuthService
    {
        Task<User> Login(string email, string password);
    }
}