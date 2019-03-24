using DataLayer;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositioryLayer.Interfaces
{
    public interface IShipRepository : IDataRepository<Ship>
    {
        void SaveShip(Ship ship);
        IEnumerable<Ship> GetShips(int playerId);
        void UpdateShip(Ship ship);
    }
}
