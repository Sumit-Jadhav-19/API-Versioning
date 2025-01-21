using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class WorkoutsController : ControllerBase
    {
        [MapToApiVersion("2.0")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "This is version 2.0", NewField = "New data" });
        }
    }
}
