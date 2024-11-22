using Member.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Member.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService memberService;

        public MembersController(IMemberService memberService)
        {
            this.memberService = memberService;
        }
        // GET: api/<MembersController>
        [HttpGet]
        public ActionResult<IList<Domain.Member>> Get()
        {
            return Ok(this.memberService.GetAllMembers());
        }
    }
}
