using Golden_Ball.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Golden_Ball.API.PlayerContext
{
    public class PlayerInfoContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Player> Players { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<StatOfPlayer> StatsOfPlayers { get; set; }

        public PlayerInfoContext(DbContextOptions<PlayerInfoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
    }
}    
