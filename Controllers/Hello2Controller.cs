using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControllersExt
{
    [ApiController]
    [Route("[controller]")]
    public class Hello2Controller : ControllerBase
    {
        [HttpGet("time")]
        public string GetCurrentTime()
        {
            return $"Hello from external {this.GetType().Name}. Current time is: {DateTime.Now}";
        }


    }
}
