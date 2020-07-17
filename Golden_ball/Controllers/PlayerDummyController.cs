using Golden_Ball.API.PlayerContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Golden_Ball.API.Controllers
{
    [ApiController]
    [Route("api/testdatabase")]
    public class PlayerDummyController : ControllerBase
    {
        private readonly PlayerInfoContext _ctx;
        public PlayerDummyController(PlayerInfoContext ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }

        [HttpGet]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
