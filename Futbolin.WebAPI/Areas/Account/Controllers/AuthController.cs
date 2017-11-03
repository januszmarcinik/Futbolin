using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Futbolin.WebAPI.Areas.Account.Models.Auth;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Options;
using Futbolin.Core.Settings;

namespace Futbolin.WebAPI.Areas.Account.Controllers
{
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private JwtTokenSettings _jwtTokenSettings;

        public AuthController(IOptions<JwtTokenSettings> jwtTokenSettings)
        {
            _jwtTokenSettings = jwtTokenSettings.Value;
        }

        [Route("[action]")]
        [HttpPost]
        public IActionResult Token([FromBody]LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, "januszmarcinik@email.com"),
                    new Claim(ClaimTypes.Role, "Moderator"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var now = DateTime.Now;

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtTokenSettings.Key));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    issuer: _jwtTokenSettings.Issuer,
                    claims: claims,
                    notBefore: now,
                    expires: now.AddMinutes(_jwtTokenSettings.ExpiryMinutes),
                    signingCredentials: credentials);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }

            return BadRequest();
        }
    }
}