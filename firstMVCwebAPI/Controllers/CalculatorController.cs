using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstMVCwebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //api/Calculator/Add?a=10&b=15
        [HttpGet("Calculator/add")]
        public int Add(int a, int b) 
        {
            return a + b;
        }
        [HttpGet("/sum")]
        public int Sum(int a, int b)
        {
            return a + b + 1000;
        }
        [HttpPost]
        //API/Calculator/Subtract?a=10&b=15
        public int Subtract(int a, int b) 
        {
            return a - b; 
        }
        [HttpPut]
        //API/Calculator/Multiply?a=10&b=15
        public int Multiply(int a, int b) 
        { 
            return a * b; 
        }
        [HttpDelete]
       //API/Calculator/Divide?a=10&b=15 
        public int Divide(int a, int b) 
        { 
            return a / b; 
        }
    }
}
