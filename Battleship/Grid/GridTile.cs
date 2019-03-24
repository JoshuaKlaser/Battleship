using Battleship.Content;
using Battleship.Helpers;
using GameLayer.Models;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Battleship.Grid.GridController;

namespace Battleship.Grid
{
    public class GridTile
    {
        public TileStatus Status { get { return _status; } }

        private TransparentControl _control;
        private int _posX;
        private int _posY;
        private bool _hasShip;
        private bool _showShip;
        private bool _showCanPlace;
        private bool _showCantPlace;
        private TileStatus _status;
        private OnTileClick _onClick;
        private OnTileClick _onMissedShot;

        public GridTile(int posX, int posY, Control parent, OnTileClick onClick, OnTileClick onMissedShot)
        {
            _posX = posX;
            _posY = posY;
            _hasShip = false;
            _showShip = false;
            _showCanPlace = false;
            _showCantPlace = false;
            _onClick = onClick;
            _onMissedShot = onMissedShot;

            _control = new TransparentControl(OnMouseEnter, OnMouseLeave, OnMouseClick);

            _control.Size = new Size(64, 64);
            _control.Location = new Point(_posX, _posY);

            Refresh();

            parent.Controls.Add(_control);
        }

        private void Refresh()
        {
            _control.LoadImages(
                ContentResources.Water
                , _showCanPlace ? ContentResources.CanPlace : null
                , _status == TileStatus.Nothing ? null
                : _status == TileStatus.Missed ? ContentResources.MissedShot
                : _status == TileStatus.Hit ? ContentResources.Hit
                : null
                , _showShip ? ContentResources.ShipPiece : null
                , _showCantPlace ? ContentResources.CantPlace : null
                );
        }

        private void OnMouseEnter()
        {
            if (_status == TileStatus.Nothing)
                _showCanPlace = true;
            else
                _showCantPlace = true;

            Refresh();
        }

        private void OnMouseLeave()
        {
            _showCanPlace = false;
            _showCantPlace = false;

            Refresh();
        }

        private void OnMouseClick()
        {
            if (_hasShip)
            {
                _status = TileStatus.Hit;
                _showShip = true;
                _onClick();
            }
            else
            {
                _status = TileStatus.Missed;
                _onMissedShot();
            }
        }

        public void AddShip(bool renderShip)
        {
            _showShip = renderShip;
            _hasShip = true;
            Refresh();
        }

        public void AddPoint(ShipPoint point)
        {
            AddShip(point.Hit ? true : false);

            if (point.Hit)
                SetStatusHit();
            else if (point.Missed)
                SetStatusMissed();
        }

        public void SetStatusHit()
        {
            _status = TileStatus.Hit;
        }

        public void SetStatusMissed()
        {
            _status = TileStatus.Missed;
        }

        public void Remove()
        {
            _control.Dispose();
        }

        public void Hide()
        {
            _control.Hide();
        }

        public void Show()
        {
            _control.Show();
            Refresh();
        }

        public void SetHoverEvent(bool hover)
        {
            _control.EnableHoverEvents = hover;
        }
    }
}
