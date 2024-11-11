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


        //public async Task<Guid> SignUpAsync(SignUpDto signUpDto)
        //{


        //    var userAttrsList = new List<AttributeType>() {
        //        new AttributeType { Name = "email", Value = signUpDto.email, },
        //        new AttributeType { Name = "custom:city", Value = signUpDto.city, },
        //        new AttributeType { Name = "custom:first_name", Value = signUpDto.firstName, },
        //        new AttributeType { Name = "custom:last_name", Value = signUpDto.lastName, },
        //        new AttributeType { Name = "custom:postal_code", Value =   signUpDto.postalCode.ToString(), },
        //        new AttributeType { Name = "custom:telephone", Value = signUpDto.telephone.ToString(), },
        //        new AttributeType { Name = "custom:username", Value = signUpDto.userName, },
        //        new AttributeType { Name = "address", Value = "Addres por defecto", },

        //    };


        //    //Email is the same that username
        //    var signUpRequest = new SignUpRequest
        //    {
        //        UserAttributes = userAttrsList,
        //        Username = signUpDto.email,
        //        ClientId = clientId,
        //        Password = signUpDto.password,
        //    };

        //    var response = await _cognitoService.SignUpAsync(signUpRequest);
        //    string userSub = response.UserSub;

        //    return new Guid(userSub);

        //    //return response.HttpStatusCode == HttpStatusCode.OK;
        //}

        //public async Task<bool> ConfirmSignupAsync(string authCode, Guid userId)
        //{
        //    var signUpRequest = new ConfirmSignUpRequest
        //    {
        //        ClientId = clientId,
        //        ConfirmationCode = authCode,
        //        Username = userId.ToString(),
        //    };

        //    //Confirm the user in database
        //    User user = await GetUserById(userId);
        //    user.IsConfirmed = true;
        //    _dbContext.SaveChanges();

        //    var response = await _cognitoService.ConfirmSignUpAsync(signUpRequest);

        //    if (response.HttpStatusCode == HttpStatusCode.OK)
        //    {
        //        Console.WriteLine($"User was confirmed");
        //        return true;
        //    }
        //    return false;
        //}


        //public async Task<CodeDeliveryDetailsType> ResendConfirmationCodeAsync(Guid userId)
        //{
        //    var codeRequest = new ResendConfirmationCodeRequest
        //    {
        //        ClientId = clientId,
        //        Username = userId.ToString(),
        //    };

        //    var response = await _cognitoService.ResendConfirmationCodeAsync(codeRequest);


        //    return response.CodeDeliveryDetails;
        //}


        //public async Task AddUser(SignUpDto signUpDto, Guid userSub)
        //{
        //    var bytes = new UTF8Encoding().GetBytes(signUpDto.password);
        //    var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
        //    string encryptedPassword = Convert.ToBase64String(hashBytes);

        //    //User user = new User
        //    //{
        //    //    IdUser = userSub,
        //    //    Email = signUpDto.email,
        //    //    Username = signUpDto.userName,
        //    //    FirstName = signUpDto.firstName,
        //    //    LastName = signUpDto.lastName,
        //    //    Password = encryptedPassword
        //    //};

        //    //_dbContext.Add(user);
        //    //await _dbContext.SaveChangesAsync();

        //}

        ////Returns only the user id given an email
        ////The user needs to be authenticated
        //public async Task<Guid> GetUserId(string email)
        //{
        //    Guid userId = await _dbContext.Users
        //        .Where(u => u.Email == email)
        //        .Where(u => u.IsConfirmed == true)
        //        .OrderByDescending(m => m.CreatedAt)
        //        .Select(x => x.IdUser)
        //        .FirstOrDefaultAsync();

        //    return userId;

        //}

        ////Returns the user given the userId
        //public async Task<User> GetUserById(Guid userId)
        //{
        //    User user = await _dbContext.Users
        //        .Where(u => u.IdUser == userId)
        //        .FirstOrDefaultAsync();



        //    return user;

        //}

        //public async Task<InitiateAuthResponse> InitiateAuthAsync(LogInDto logInDto)
        //{
        //    var authParameters = new Dictionary<string, string>();
        //    authParameters.Add("USERNAME", logInDto.email);
        //    authParameters.Add("PASSWORD", logInDto.password);

        //    var authRequest = new InitiateAuthRequest

        //    {
        //        ClientId = clientId,
        //        AuthParameters = authParameters,
        //        AuthFlow = AuthFlowType.USER_PASSWORD_AUTH,
        //    };

        //    var response = await _cognitoService.InitiateAuthAsync(authRequest);


        //    return response;
        //}


    }
}
