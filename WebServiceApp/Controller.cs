using System;
using Microsoft.AspNetCore.Mvc;

namespace WebServiceApp
{
    [Produces("application/json")]
    [ApiController]
    [Route("[action]")]
    
    public class Controller : ControllerBase
    {
        
       [HttpGet ("{data:alpha}")]
       public IActionResult Reverse(string data)
       {
           var s = data.ToCharArray();
           Array.Reverse(s);
           var result = new string(s);
           return new JsonResult(new {result});
       }

       [HttpGet ("{data:int}")]
       public IActionResult Reverse(int data)
       {
           var result = Math.Sqrt(data);
           return new JsonResult(new {result});
       }
    }
}