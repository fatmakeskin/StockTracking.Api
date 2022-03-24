using Business.Services;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace StockTracking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService<User> userService;
        public UserController(UserService<User> _userService)
        {
            userService = _userService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            try
            {
                var users = userService.GetAll();
                return Ok(users);
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
        [HttpGet(nameof(GetById))]
        public IActionResult GetById(int id)
        {
            try
            {
                var user = userService.GetById(id);
                return Ok(user);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost(nameof(Add))]
        public IActionResult Add([FromBody] User user)
        {
            try
            {
                userService.Add(user);
                return Ok(user);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
        [HttpPut(nameof(Update))]
        public IActionResult Update([FromBody] User user)
        {
            try
            {
                userService.Update(user);
                return Ok(user);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromBody] int id)
        {
            try
            {
                userService.Delete(id);
                return Ok(id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }



    }
}
