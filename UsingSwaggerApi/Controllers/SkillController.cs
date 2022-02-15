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
    public class SkillController : ControllerBase
    {
        private readonly UsingSwaggerApiContext _context;

        public SkillController(UsingSwaggerApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Skill>>> GetSkill()
        {
            return await _context.Skill.ToListAsync();
        }

            ////// GET: api/<SkillController>
            ////[HttpGet]
            ////public IEnumerable<string> Get()
            ////{
            ////    return new string[] { "value1", "value2" };
            ////}

            ////// GET api/<SkillController>/5
            ////[HttpGet("{id}")]
            ////public string Get(int id)
            ////{
            ////    return "value";
            ////}

            ////// POST api/<SkillController>
            ////[HttpPost]
            ////public void Post([FromBody] string value)
            ////{
            ////}

            ////// PUT api/<SkillController>/5
            ////[HttpPut("{id}")]
            ////public void Put(int id, [FromBody] string value)
            ////{
            ////}

            ////// DELETE api/<SkillController>/5
            ////[HttpDelete("{id}")]
            ////public void Delete(int id)
            ////{
            ////}
        }
    }
