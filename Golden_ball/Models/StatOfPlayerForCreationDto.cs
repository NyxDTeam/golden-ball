using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Golden_Ball.API.Models
{
    public class StatsOfPlayerForCreationDto
    {
            
        public int Goals { get; set; }

        public int Assists { get; set; }
       
        [Required(ErrorMessage = "You should put a number")]
        public int Id { get; internal set; }
    }
}
