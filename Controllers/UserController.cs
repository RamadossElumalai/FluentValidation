using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidationDemo.Models;
using FluentValidation;

namespace FluentValidationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IValidator<User> _validator;

        public UserController(IValidator<User> validator)
        {
            _validator = validator;
        }

        [HttpGet("GetUsers")]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            return new List<User>{
                new User{
                    Name = "Ramadoss E"
                }
            };
        }

        [HttpPost("AddUser")]
        public async Task<ActionResult> AddUser(User user)
        {
            // It will throw exception when validations fails
            //await _validator.ValidateAndThrowAsync(user)

            var result = await _validator.ValidateAsync(user);
            if (!result.IsValid){
                return BadRequest(result.Errors);
            }
            return Ok(user);    
        }
    }
}
