using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using VideoGameApi.DTO;
using VideoGameApi.Entities;
using VideoGameApi.Services;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {        
        
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDTO request)
        {
           var user = await authService.RegisterAsync(request); 

           if(user is null) return BadRequest("User already exist"); 

           return Ok(user);

        }

        [HttpPost("Login")]
        public async  Task<ActionResult<string>> Login(UserDTO request)
        {
           var token = await authService.LoginAsync(request); 
           if (token is null) return BadRequest("Invalid Username or Password"); 

           return Ok(token);

        }

        [Authorize]
        [HttpGet]
        public IActionResult AuthenticatedOnlyEndPoint()
        {
        
            return Ok("You are authenticated");

        }

        

    }
    
}