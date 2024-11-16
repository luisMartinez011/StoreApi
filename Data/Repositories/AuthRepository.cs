using StoreAPI.Data;
using StoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using StoreAPI.DTOs;
using System.Net;
using System.Text;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace StoreAPI.Data.Repositories
{
    public interface IAuthRepository
    {
        Task<bool> RegisterUser(string name, string email, string password);
        Task<string> AuthenticateUser(string email, string password);
        Task<User> GetUserByEmail(string email);
    }

    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly SymmetricSecurityKey _key;

        public AuthRepository(AppDbContext dbContext,
            IConfiguration configuration)
        {
            _dbContext = dbContext;
            string _tokenKey = configuration.GetValue<string>("TokenKey");
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenKey));
        }

        public async Task<bool> RegisterUser(string name, string email, string password)
        {
            try
            {
                bool isExist = await _dbContext.Users.AnyAsync(u => u.Email == email);
                if (isExist)
                {
                    return false;
                }


                User user = new User();

                user.Name = name;
                user.Email = email;

                user.Password = BCrypt.Net.BCrypt.HashPassword(password);

                Cart cart = new Cart(); // Crear carrito asociado
                user.Cart = cart;
                var res = await _dbContext.Users.AddAsync(user);

                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<string> AuthenticateUser(string email, string password)
        {
            try
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(m => m.Email == email);

                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(JwtRegisteredClaimNames.NameId,user.Email)
                    };

                    var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(claims),
                        Expires = DateTime.Now.AddDays(500),
                        SigningCredentials = creds,
                    };



                    var tokenHandler = new JwtSecurityTokenHandler();

                    var token = tokenHandler.CreateToken(tokenDescriptor);

                    return tokenHandler.WriteToken(token);
                }
                throw new Exception("Usuario no existe");
            }
            catch (Exception ex)
            {
                throw new Exception("Error");
            }

        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            return user;
        }

 

    }
}
