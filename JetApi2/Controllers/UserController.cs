using JET2.Entities.User;
using JET2.Entities.User.Data;
using JET2.Entities.User.IUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace JetApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        [HttpPut("UserInsert")]
        public async Task<IActionResult> UserInsert([FromBody] User user)
        {
            try
            {
                _userRepository.UserInsert(user.FirstName, user.LastName, user.PhoneNumber, user.Email);
                //new UserRepository().UserInsert(user.FirstName, user.LastName, user.PhoneNumber, user.Email);
                return Ok();
            }
            catch (Exception ex) 
            {
                throw new Exception("An error occured in the endpoint");
            }


        }
    }
}
