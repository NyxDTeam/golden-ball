using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace Golden_Ball.API.Controllers
{
    [ApiController]
    [Route("api/player/statsofplayers")]
    public class StatsOfPlayerController : ControllerBase
    {
        private readonly ILogger<StatsOfPlayerController> _logger;

        public StatsOfPlayerController(ILogger<StatsOfPlayerController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{playerId}")]
        public IActionResult GetStatOfPlayer(int playerId)
        {
            var player = PlayersData.Current.Players.FirstOrDefault(c => c.Id == playerId);

            if (player == null)
                return NotFound();
            
            if (player.PlayerStats == null)
                return NotFound();

            return Ok(player.PlayerStats);
        }
    }
}