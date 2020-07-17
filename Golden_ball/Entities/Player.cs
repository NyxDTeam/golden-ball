using Golden_Ball.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Golden_Ball.API.Entities
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        
        public string Name { get; set; }
        [MaxLength(200)]

        //  public string Stats { get; set; }


        public int Year { get; set; }       
        [MaxLength(50)]

        public string Club { get; set; }
        [MaxLength(200)]
        

        public string Nationality { get; set; }
        [MaxLength(200)]

        public ICollection<StatOfPlayersDto> PlayerStats { get; set; } = new List<StatOfPlayersDto>();
    }
}
