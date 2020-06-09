using System.Collections.Generic;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    // pattern [baseurl]/api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            
        }

        [HttpGet]
        public ActionResult <Command> GetCommandById(int id)
        {
            
        }
    }
}