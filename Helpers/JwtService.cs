using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace BackEnd.Helpers
{
    public class JwtService
    {
        private string secureKey = "BuiVietQuangCheckPass";
        public string generate(Guid Id)
        {
            var sysmmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secureKey));

            var credentials = new SigningCredentials(sysmmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            JwtHeader header = new JwtHeader(credentials);

            var payload = new JwtPayload(Id.ToString(), null, null, null, DateTime.Today.AddDays(1));

            JwtSecurityToken secureToken = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(secureToken);
        }
        public JwtSecurityToken Verify(string jwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            Byte[] key = Encoding.ASCII.GetBytes(secureKey);

            tokenHandler.ValidateToken(jwt, new TokenValidationParameters
                {   
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = false,
                    ValidateAudience = false
                }, out SecurityToken validatedToken);

            return (JwtSecurityToken) validatedToken;

        }
        
    }
}