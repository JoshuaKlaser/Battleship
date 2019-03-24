using DataLayer;
using DataLayer.Contexts;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using RepositioryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositioryLayer.InMemoryRepository
{
    public class PlayerRepository : DataRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(string dbName) : this(new BattleshipContext(OptionsBuilder.GetInMemoryOptions(dbName))) { }

        public PlayerRepository(BattleshipContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void SavePlayer(Player player)
        {
            _dbContext.Players.Add(player);
            _dbContext.SaveChanges();
        }

        public int CreatePlayer(string name)
        {
            Player newPlayer = new Player() { Name = name };

            var player = _dbContext.Players.Add(newPlayer);

            _dbContext.SaveChanges();

            return player.Entity.Id;
        }
    }
}
