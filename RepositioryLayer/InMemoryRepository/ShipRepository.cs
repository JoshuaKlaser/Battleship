using DataLayer;
using DataLayer.Contexts;
using DataLayer.Repositories;
using RepositioryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositioryLayer.InMemoryRepository
{
    public class ShipRepository : DataRepository<Ship>, IShipRepository
    {
        public ShipRepository(string dbName) : this(new BattleshipContext(OptionsBuilder.GetInMemoryOptions(dbName))) { }

        public ShipRepository(BattleshipContext context) : base(context) { }

        public void SaveShip(Ship ship)
        {
            _dbContext.Ships.Add(ship);
            _dbContext.SaveChanges();
        }
    }
}
