using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualJournal.Models;
using VirtualJournal.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VirtualJournal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        public readonly IRegistration _context = null;
        public RegistrationController(IRegistration context)
        {
            _context = context;
        }
        // GET: api/<RegistrationController>
        [HttpGet]
        public async Task<IActionResult> GetAllRegistrationsAsync()
        {
            try
            {
                return Ok(await _context.GetAllRegistrations());
            }
            catch
            {
                return NoContent();
            }
        }

        // POST api/<RegistrationController>
        [HttpPost]
        public async Task<IActionResult> AddRegistration(Registration registration)
        {
            try
            {
                await _context.AddRegistration(registration);
                return Ok("registration Successful");
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // PUT api/<RegistrationController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> updateRegistration(Registration registration)
        {
            try
            {
                await _context.UpdateRegistration(registration);
                return Ok("Registration Updated");
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // DELETE api/<RegistrationController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            try
            {
                await _context.DeleteRegistrationById(id);
                return Ok("Registration Deleted");
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        //*Code from here is commented off at present But will be reverted to working whenever required
        /*//GET api/<RegistrationController>/<username><passowrd>
        [HttpGet("{password}")]
        public async Task<IActionResult> ValidateRegistration(string username, string password)
        {
            try
            {
                if (await _context.validateRegistration(username, password))
                {
                    return Ok("Logged In");
                }
                return Ok("username or password entered are mismatched");
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        //GET api/<RegistrationController>/<username>
        [HttpGet("{username}")]
        public async Task<IActionResult> ValidateUsername(string username)
        {
            try
            {
                if (await _context.validateUsername(username))
                {
                    return Ok();
                }
                return Ok("username already exists");
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }*/
    }
}
