using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstMVCwebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("Demo/add")]
        public int Add(int a, int b)
        {
            return a + b + 50000;
        }
    }
}
