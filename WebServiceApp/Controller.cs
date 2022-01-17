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
           
           var n = s.Length;
           
           for (var i = 0; i < n / 2; i++) {
               (s[i], s[n - i - 1]) = (s[n - i - 1], s[i]);
           }
           
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