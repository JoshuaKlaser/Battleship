using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositioryLayer.Interfaces;
using RepositioryLayer.InMemoryRepository;
using Shared.Enums;

namespace GameLayer
{
    public class GameLogic
    {
        IShipPieceRepository _shipPieceRepo = null;
        IShipRepository _shipRepo = null;
        IPlayerRepository _playerRepo = null;
        IStateRepository _stateRepo = null;

        public StateEnum CurrentState { get; private set; }

        public GameLogic(string dbName)
        {
            _shipPieceRepo = new ShipPieceRepository(dbName);
            _shipRepo = new ShipRepository(dbName);
            _playerRepo = new PlayerRepository(dbName);
            _stateRepo = new StateRepository(dbName);

            PreloadData();

            CurrentState = StateEnum.Player1Name;
        }

        private void PreloadData()
        {
            _stateRepo.CreateInitData();
        }

        public void MoveToNextState()
        {
            CurrentState = (StateEnum)_stateRepo.GetNextState((int)CurrentState);
        }

        public void RegsiterPlayer1(string name)
        {
            _playerRepo.CreatePlayer(name);
        }
    }
}
