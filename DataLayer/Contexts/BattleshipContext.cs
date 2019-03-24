using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Contexts
{
    public class BattleshipContext : DbContext
    {
        public BattleshipContext(DbContextOptions<BattleshipContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<ShipPiece> ShipPieces { get; set; }
        public DbSet<State> States { get; set; }
    }
}
