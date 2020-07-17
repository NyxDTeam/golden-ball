using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Golden_Ball.API.Models
{
    public class  StatOfPlayersDto
    {
      
        public int Goals { get; set; }

        public int Assists { get; set; }
        public int Id { get; internal set; }
    }
}
