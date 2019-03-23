using DataLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositioryLayer.InMemoryRepository
{
    public class OptionsBuilder
    {
        public static DbContextOptions<BattleshipContext> GetInMemoryOptions(string inMemDatabaseName)
        {
            // Decided to use an in memory database so that there wouldn't have to be any set up when running the game.
            // This shouldn't be used in production unless it's for testing since it will not perform any relational loading or checks on the data entities.

            var builder = new DbContextOptionsBuilder<BattleshipContext>();
            builder.UseInMemoryDatabase(inMemDatabaseName);
            return builder.Options;
        }
    }
}
