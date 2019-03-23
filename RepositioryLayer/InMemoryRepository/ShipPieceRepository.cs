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
    public class ShipPieceRepository : DataRepository<ShipPiece>, IShipPieceRepository
    {
        public ShipPieceRepository(string dbName) : this(new BattleshipContext(OptionsBuilder.GetInMemoryOptions(dbName))) { }

        private ShipPieceRepository(BattleshipContext context) : base(context) { }

        public void SaveShipPiece(ShipPiece piece)
        {
            _dbContext.ShipPieces.Add(piece);
            _dbContext.SaveChanges();
        }
    }
}
