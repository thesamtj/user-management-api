using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet("Employees")]
        public IEnumerable<string> Get()
        {
            return new List<string> { "John", "Peter", "James" };
        }
    }
}
