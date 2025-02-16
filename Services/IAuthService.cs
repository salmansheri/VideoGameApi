using VideoGameApi.DTO;
using VideoGameApi.Entities;

namespace VideoGameApi.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDTO request);
        Task<string?> LoginAsync(UserDTO request); 
        
    }
}