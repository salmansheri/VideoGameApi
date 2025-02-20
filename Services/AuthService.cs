using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VideoGameApi.Data;
using VideoGameApi.DTO;
using VideoGameApi.Entities;


namespace VideoGameApi.Services
{
    public class AuthService(VideoGameDBContext context, IConfiguration configuration) : IAuthService
    {
        public async  Task<string?> LoginAsync(UserDTO request)
        {
            var user = await context.User.FirstOrDefaultAsync(u => u.Username == request.Username); 

            if(user is null)
            {
                return null; 
            }
        

            if(new PasswordHasher<User>().VerifyHashedPassword(user, user.PasswordHash, request.Password) == PasswordVerificationResult.Failed)
            {
                return null; 
            }
            string token = CreateToken(user);  

            return token;
        }

        public async  Task<User?> RegisterAsync(UserDTO request)
        {
            if(await context.User.AnyAsync(u => u.Username == request.Username ))
            {
                return null; 

            }
            var user  = new User(); 
              var hashedPassword = new PasswordHasher<User>()
                .HashPassword(user, request.Password); 

            user.Username = request.Username;
            user.PasswordHash = hashedPassword; 
            user.Role = request.Role; 

            context.User.Add(user); 

            await context.SaveChangesAsync();
            
            return user; 
        }

        private string CreateToken(User user)
        {
            var claim = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role)
            }; 

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(configuration.GetValue<string>("AppSettings:Token")!)
            ); 
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512); 

            var tokenDescriptor = new JwtSecurityToken(
                issuer: configuration.GetValue<string>("AppSettings:Issuer"),
                audience: configuration.GetValue<string>("AppSettings:audience"),
                claims: claim,
                expires:DateTime.UtcNow.AddDays(1),
                signingCredentials: creds
            ); 

            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor); 

        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create();

            rng.GetBytes(randomNumber); 

            return Convert.ToBase64String(randomNumber);
        }

        private async Task<string> GenerateRefreshTokenAsync(User user)
        {
            var refreshToken = GenerateRefreshToken(); 
            user.RefreshToken = refreshToken; 
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7);
            await context.SaveChangesAsync(); 
            return refreshToken; 


        }

    }
}