using Golden_Ball.API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Golden_Ball.Models
{
    public class PlayerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

      //  public string Stats { get; set; }

       
        public int Year { get; set; }

        public string Club { get; set; }

        public string Nationality { get; set; }
        public int NumberofStats
        {
            get
            {
                return PlayerStats.Count;
            }
        }

        public ICollection<StatOfPlayersDto> PlayerStats { get; set; } = new List<StatOfPlayersDto>();
       
    }
}
