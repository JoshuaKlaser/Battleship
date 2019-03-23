using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositioryLayer.Interfaces;
using RepositioryLayer.InMemoryRepository;

namespace GameLayer
{
    public class GameLogic
    {
        IShipPieceRepository _shipPieceRepo = null;
        IShipRepository _shipRepo = null;
        IPlayerRepository _playerRepo = null;
        IStateRepository _stateRepo = null;

        public GameLogic(string dbName)
        {
            _shipPieceRepo = new ShipPieceRepository(dbName);
            _shipRepo = new ShipRepository(dbName);
            _playerRepo = new PlayerRepository(dbName);
            _stateRepo = new StateRepository(dbName);

            PreloadData();
        }

        private void PreloadData()
        {
            _stateRepo.CreateInitData();
        }
    }
}
