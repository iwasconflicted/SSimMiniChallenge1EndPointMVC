using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SSimMiniChallenge1EndPointMVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Hello : ControllerBase
    {
        [HttpGet]

        public string SayHello(string firstName, string LastName){
        return "Hello " + firstName + " " + LastName + "" + ", " + "it is a pleasure to meet you!";

        }
        
    }
}