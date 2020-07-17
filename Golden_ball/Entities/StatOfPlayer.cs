using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Golden_Ball.API.Entities
{
    public class StatOfPlayer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Goals { get; set; }
        [Required]
        [MaxLength(50)]
        public int Assists { get; set; }
        [Required]
        [MaxLength(50)]
        public int Id { get; internal set; }
        [ForeignKey("PlayerId")]
        public Player player { get; set; } // onde vai ser criada a relação entre players e stats

        public int PlayerId { get; set; }
    }
}
