using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingSwaggerApi.Data;
using UsingSwaggerApi.Model;

namespace UsingSwaggerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AssessmentController : ControllerBase
    {
        private readonly UsingSwaggerApiContext _context;

        public AssessmentController(UsingSwaggerApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssessmentStatus>>> GetAssessmentStatus()
        {
            return await _context.AssessmentStatus.ToListAsync();
        }
    }
}
