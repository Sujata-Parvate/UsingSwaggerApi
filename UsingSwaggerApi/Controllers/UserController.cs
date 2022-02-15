using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingSwaggerApi.Data;
using UsingSwaggerApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UsingSwaggerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UsingSwaggerApiContext _context;

        public UserController(UsingSwaggerApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _context.User.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var User = await _context.User.FindAsync(id);

            if (User == null)
            {
                return NotFound();
            }

            return User;
        }

            //// GET: api/<UserController>
            //[HttpGet]
            //public IEnumerable<string> Get()
            //{
            //    return new string[] { "value1", "value2" };
            //}

            //// GET api/<UserController>/5
            //[HttpGet("{id}")]
            //public string Get(int id)
            //{
            //    return "value";
            //}

            //// POST api/<UserController>
            //[HttpPost]
            //public void Post([FromBody] string value)
            //{
            //}

            //// PUT api/<UserController>/5
            //[HttpPut("{id}")]
            //public void Put(int id, [FromBody] string value)
            //{
            //}

            //// DELETE api/<UserController>/5
            //[HttpDelete("{id}")]
            //public void Delete(int id)
            //{
            //}
        }
    }
