using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApi_Async_Efcore_New.Repository;
using WebApi_Async_Efcore_New.Models;

namespace WebApi_Async_Efcore_New.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private ISchool _dt;
        public SchoolController(ISchool dt)  //Dependency Inject
        {
            _dt = dt;
        }

        [HttpGet]
        public async Task<IEnumerable<School>> getSchool()
        {
            return await _dt.GetAllSchool();
        }
        [HttpGet("{roll}")]
        public async Task<ActionResult<School>> getSchool(int roll)
        {
            return await _dt.GetSchool(roll);
        }

        [HttpPost]
        public async Task<ActionResult<School>> PostSchool([FromBody] School sobj)
        {
            var newschool = await _dt.InsertSchool(sobj);
            return CreatedAtAction(nameof(getSchool), new { roll = newschool.Rollno }, newschool);
        }

        [HttpPut]
        public async Task<ActionResult> updateSchool(int roll, [FromBody] School sobj)
        {
            if (roll != sobj.Rollno)
            {
                return BadRequest();

            }
            await _dt.UpdateSchool(sobj);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> deleteSchool(int roll)
        {
            var res = await _dt.GetSchool(roll);
            if (res == null)
            {
                return NoContent();
            }
            await _dt.DeleteSchool(roll);
            return NoContent();
        }
    }
}
