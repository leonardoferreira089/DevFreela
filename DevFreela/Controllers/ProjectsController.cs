using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
