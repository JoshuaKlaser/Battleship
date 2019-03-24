using DataLayer;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositioryLayer.Interfaces
{
    public interface IShipPieceRepository : IDataRepository<ShipPiece>
    {
        void SaveShipPiece(ShipPiece piece);
        void SaveShipPieces(IEnumerable<ShipPiece> pieces);
    }
}
