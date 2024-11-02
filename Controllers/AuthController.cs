using CarApi.Models;
using CarApi.Models.ResponsesTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Data.Repositories;

//!! Revisar si estos packages son utiles o no, no m acuerdo para q eran XD
//using ServiceStack;
//using ServiceStack.Web;
using StoreAPI.DTOs;
using System.Collections;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarApi.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository){
            _authRepository = authRepository;
        }

        /// <summary>
        /// SignUp a user. 
        /// 
        /// </summary>
        [HttpPost("SignUp")]
        [ProducesResponseType(typeof(ResponseSignUp), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> SignUp([FromBody] SignUpDto signUpDto)
        {
            try
            {
                Guid userId = await _authRepository.SignUpAsync(signUpDto);
                await _authRepository.AddUser(signUpDto, userId);

                string message = "User succesfully created";

                ResponseSignUp response = new ResponseSignUp { 
                    UserId = userId,
                    Message = message
                    };
                return Ok(response);

            }catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

        /// <summary>
        /// Confirm User with authCode. The authcode is sent via email, you have 15 minutes until the code expires.
        /// 
        /// </summary>
        /// <response code="200">return confirmation message </response>
        [HttpPost("ConfirmUser")]
        public async Task<IActionResult> ConfirmUser(string authCode, Guid userId)
        {
            try
            {
                await _authRepository.ConfirmSignupAsync(authCode, userId);


                ResponseLogIn response = new ResponseLogIn
                {
                    UserId = userId,
                    Token = "fjduifduh"
                };
                return Ok(response);


            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

        /// <summary>
        /// Resend a new confirmation code to a user. Expiracy each 15 minutes
        /// </summary>
        /// <param name="userId">The user Id who will receive the code.</param>
        ///  <response code="200">return confirmation message </response>
        [HttpPost("ResendConfirmationCode")]
        public async Task<IActionResult> ResendConfirmationCode(Guid userId)
        {
            try
            {
                var res = await _authRepository.ResendConfirmationCodeAsync( userId);


                return Ok("Check your email for your confirmation code");

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }


        /// <summary>
        /// Login a user who is already confirmed.
        /// 
        /// </summary>
        [HttpPost("LogIn")]
        [ProducesResponseType(typeof(ResponseLogIn), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> LogIn([FromBody] LogInDto logInDto)
        {
            try
            {
                var res = await _authRepository.InitiateAuthAsync(logInDto);

                Guid userId = await _authRepository.GetUserId(logInDto.email);

                string token = res.AuthenticationResult.AccessToken;
                ResponseLogIn response = new ResponseLogIn
                {
                    UserId = userId,
                    Token = token
                };
                //return new HttpResult( HttpStatusCode.Accepted)'
                return Ok(response);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

        // GET api/<AuthController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<AuthController>
        
    }
}
