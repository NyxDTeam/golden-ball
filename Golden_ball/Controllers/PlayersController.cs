using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Golden_Ball.Controllers
{
    [ApiController]
    [Route("api/players")]
    public class PlayersController : ControllerBase
    {
        [HttpGet] // para retornar todas as cidades no postman
        public IActionResult GetPlayers()
        {
            return Ok(PlayersData.Current.Players);
        }

        [HttpGet("{id}")] // retorna apenas um jogador
        public IActionResult GetPlayer(int id)
        {
            var playerToReturn = (PlayersData.Current.Players.FirstOrDefault(c => c.Id == id));
            
            if (playerToReturn == null)
            {
                return NotFound();
            }
            return Ok(playerToReturn);
        }
        
    }
    

}
    
