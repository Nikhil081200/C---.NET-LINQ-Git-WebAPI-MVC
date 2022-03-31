using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        IMember memobj = new Models.MemberRepo();   //Dependency Inj

        [HttpGet]
        public ActionResult<IEnumerable<Member>> getAllmem()
        {
            return memobj.GetAllMember();
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Member>> getmem(int id)
        {
            return memobj.GetMember(id);
        }
    }
}
