using CatseyeProject.Configuration;
using CatseyeProject.Models;
using CatseyeProject.Models.DTOs;
using CatseyeProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CatseyeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        //private readonly JwtConfig _jwtConfig;

        public AuthenticationController(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }


        [HttpPost]
        [Route("Registration")]
        public async Task<IActionResult> Registration([FromBody]UserRegistrationRequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                var user_exist = await _userManager.FindByEmailAsync(requestDto.Email);

                //Check User 
                if (user_exist!=null)
                {
                    return BadRequest(new AuthResult() { Result = false, Errors = new List<string>() { "Email Already Exist" } }) ;
                }

                //Create User

                var new_user = new IdentityUser()
                {
                    Email = requestDto.Email,
                    UserName = requestDto.Email
                };

                var is_created = await _userManager.CreateAsync(new_user, requestDto.Password);
                if (is_created.Succeeded)
                {
                    //generate token
                    var token = GenerateJwtToken(new_user);

                    return Ok(new AuthResult() { Result = true, Token=token });

                }
                return BadRequest(new AuthResult() { Result = false, Errors = new List<string>() { "Server Error" } });
            }

            return BadRequest();
        }


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                // check user if exist
                var existing_user = await _userManager.FindByNameAsync(requestDto.Email);
                if (existing_user==null)
                {
                    return BadRequest(new AuthResult() { Result = false, Errors = new List<string>() { "Invalid Payload" } });
                }

                var isCorrect = await _userManager.CheckPasswordAsync(existing_user, requestDto.Password);

                if (!isCorrect)
                {
                    return BadRequest(new AuthResult() { Result = false, Errors = new List<string>() { "Invalid Credential" } });
                }

                var jwtToken = GenerateJwtToken(existing_user);
                return Ok(new AuthResult() { Result = true, Token = jwtToken });

            }
            return BadRequest(new AuthResult() { Result = false, Errors = new List<string>() { "Invalid Payload" } });
        }



        


        private string GenerateJwtToken(IdentityUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JwtConfig:Secret").Value);

            // token descriptor

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Email, value: user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToUniversalTime().ToString())
                }),

                Expires = DateTime.Now.AddHours(1),
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256)

            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;



        }

       
    }
}
