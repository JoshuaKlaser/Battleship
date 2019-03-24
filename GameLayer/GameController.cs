using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositioryLayer.Interfaces;
using RepositioryLayer.InMemoryRepository;
using Shared.Enums;
using DataLayer;
using System.Drawing;
using GameLayer.Models;

namespace GameLayer
{
    public class GameController
    {
        IShipPieceRepository _shipPieceRepo = null;
        IShipRepository _shipRepo = null;
        IPlayerRepository _playerRepo = null;
        IStateRepository _stateRepo = null;

        private int _currentPlayer;

        private int _player1;
        private int _player2;

        public StateEnum CurrentState { get; private set; }

        public GameController(string dbName)
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
            if (CurrentState == StateEnum.PlayerAttack || CurrentState == StateEnum.Finished)
                return;

            CurrentState = (StateEnum)_stateRepo.GetNextState((int)CurrentState);
        }

        public void RegsiterPlayer1(string name)
        {
            _player1 = _playerRepo.CreatePlayer(name);
            _currentPlayer = _player1;
        }

        public void RegsiterPlayer2(string name)
        {
            _player2 = _playerRepo.CreatePlayer(name);
            _currentPlayer = _player2;
        }

        public void AddShip(List<Point> pieces)
        {
            var shipPieces = pieces.Select(p => new ShipPiece() { PosX = p.X, PosY = p.Y, IsHit = false });

            var newShip = new Ship() { PlayerId = _currentPlayer, ShipPieces = shipPieces.ToList() };

            _shipRepo.SaveShip(newShip);
        }

        public void ChangeToNextPlayer()
        {
            _currentPlayer = GetEnemyPlayer();
        }

        public int GetEnemyPlayer()
        {
            if (_currentPlayer == _player1)
                return _player2;
            else
                return _player1;
        }

        public string GetCurrentPlayerName()
        {
            return _playerRepo.GetById(_currentPlayer).Name;
        }

        public List<List<ShipPoint>> GetEnemyShips()
        {
            var returnList = new List<List<ShipPoint>>();

            var enemyShips = _shipRepo.GetShips(GetEnemyPlayer());

            foreach (var ship in enemyShips)
            {
                var pointList = new List<ShipPoint>();
                pointList.AddRange(ship.ShipPieces.Select(sp => new ShipPoint(ship.Id, sp.Id, sp.PosX, sp.PosY, sp.IsHit, sp.IsMissed)));

                returnList.Add(pointList);
            }

            return returnList;
        }

        public void UpdateEnemyShips(List<List<ShipPoint>> ships)
        {
            foreach (var dataShip in ships)
            {
                var shipEntity = _shipRepo.GetById(dataShip[0].ShipId);

                foreach (var piece in shipEntity.ShipPieces)
                {
                    var dataPiece = dataShip.FirstOrDefault(sp => sp.ShipPieceId == piece.Id);

                    piece.IsHit = dataPiece.Hit;
                    piece.IsMissed = dataPiece.Missed;
                }

                _shipRepo.UpdateShip(shipEntity);
            }
        }

        public void FinishGame()
        {
            CurrentState = StateEnum.Finished;
        }
    }
}
