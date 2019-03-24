using Battleship.Game;
using GameLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship.Grid
{
    public class GridController
    {
        public delegate void OnTileClick();

        private List<List<GridTile>> _tiles = null;
        private Control _parent = null;
        private OnTileClick _onMissedShot;
        private OnTileClick _onClick;
        private List<List<ShipPoint>> _loadedPoints;

        public GridController(Control control, OnTileClick onClick, OnTileClick onMissedShot)
        {            
            _parent = control;
            _onClick = onClick;
            _onMissedShot = onMissedShot;
        }

        public void GenerateGrid()
        {
            RemoveAll();

            _tiles = new List<List<GridTile>>();

            for (int i = 0; i < 10; i++)
            {
                var tileRow = new List<GridTile>();

                for (int q = 0; q < 10; q++)
                {
                    var tile = new GridTile(i * 64, q * 64, _parent, _onClick, _onMissedShot);
                    tileRow.Add(tile);
                }

                _tiles.Add(tileRow);
            }
        }

        public void RemoveAll()
        {
            if (_tiles == null)
                return;

            foreach (var row in _tiles)
            {
                foreach (var tile in row)
                {
                    tile.Remove();
                }
            }
        }

        public void SetHoverEvents(bool hoverEvent)
        {
            foreach (var row in _tiles)
            {
                foreach (var tile in row)
                {
                    tile.SetHoverEvent(hoverEvent);
                }
            }
        }

        public void AddShipToShow(Ship ship)
        {
            var points = ship.GetShipPoints();

            foreach (var point in points)
            {
                _tiles[point.X - 1][point.Y - 1].AddShip(true);
            }
        }

        public void Hide()
        {
            if (_tiles == null)
                return;

            foreach (var row in _tiles)
            {
                foreach (var tile in row)
                {
                    tile.Hide();
                }
            }
        }

        public void Show()
        {
            if (_tiles == null)
                return;

            foreach (var row in _tiles)
            {
                foreach (var tile in row)
                {
                    tile.Show();
                }
            }
        }

        public void LoadShipsToAttack(List<List<ShipPoint>> points)
        {
            _loadedPoints = null;

            foreach (var ship in points)
            {
                foreach (var piece in ship)
                {
                    _tiles[piece.X - 1][piece.Y - 1].AddPoint(piece);
                }
            }

            _loadedPoints = points;
        }

        public List<List<ShipPoint>> GetUpdatedLoadedPoints()
        {
            if (_loadedPoints == null)
                return null;

            foreach (var ship in _loadedPoints)
            {
                foreach (var piece in ship)
                {
                    piece.Hit = _tiles[piece.X - 1][piece.Y - 1].Status == Shared.Enums.TileStatus.Hit ? true : false;
                    piece.Missed = _tiles[piece.X - 1][piece.Y - 1].Status == Shared.Enums.TileStatus.Missed ? true : false;
                }
            }

            return _loadedPoints;
        }

        public bool IsLoadedPointsFinished()
        {
            bool completed = true;

            foreach (var ship in _loadedPoints)
            {
                foreach (var piece in ship)
                {
                    var isHit = _tiles[piece.X - 1][piece.Y - 1].Status == Shared.Enums.TileStatus.Hit;

                    if (!isHit)
                        completed = false;

                    if (!completed)
                        break;
                }

                if (!completed)
                    break;
            }

            return completed;
        }
    }
}
