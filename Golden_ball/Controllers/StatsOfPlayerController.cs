using Golden_Ball.API.Models;
using Golden_Ball.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Golden_Ball.API.Controllers
{
    [ApiController]
    [Route("api/player/{playerId}/statsofplayers")]
    public class StatsOfPlayerController
    {
        private readonly ILogger<StatsOfPlayerController> _logger;

        public StatsOfPlayerController (ILogger<StatsOfPlayerController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public IActionResult GetStatsOfPlayers(int playerId)
        {
            var player = PlayersData.Current.Players.FirstOrDefault(c => c.Id == playerId);

            if (player == null)
            {
                _logger.LogInformation($"Player with id {playerId} wasn't found when accessing stats of players ");
                return NotFound();
            }

            return Ok(player.PlayerStats);
        }

        private IActionResult Ok(PlayerDto player)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}/statsofplayers")]
        public IActionResult GetStatOfPlayer(int playerId, int id)
        {
            var player = PlayersData.Current.Players.FirstOrDefault(c => c.Id == playerId);

            if (player == null)
            {
                return NotFound();        
            }


            var statOfPlayer = player.PlayerStats.FirstOrDefault(c => c.Id == id);
            if (statOfPlayer == null)
            {
                return NotFound();
            }
            return Ok(statOfPlayer);
        }

        
        
        
        
        
        
        
        
        
        private IActionResult Ok(StatOfPlayersDto statOfPlayer)
        {
            throw new NotImplementedException();
        }

        private IActionResult NotFound()
        {
            throw new NotImplementedException();
        }

        private IActionResult Ok(ICollection<StatOfPlayersDto> playerStats)
        {
            throw new NotImplementedException();
        }
    }
        
  
       
        
    
}
