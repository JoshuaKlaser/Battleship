using Battleship.Content;
using Battleship.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship.Grid
{
    public class GridTile
    {
        public PictureBox WaterAndBorder { get; private set; }
        public PictureBox Status { get; private set; }
        public PictureBox ShipPiece { get; private set; }

        public TransparentControl _control;

        private int _posX;
        private int _posY;

        public GridTile(int posX, int posY, Control parent)
        {
            _posX = posX;
            _posY = posY;

            _control = new TransparentControl();

            _control.Size = new Size(64, 64);
            _control.Location = new Point(_posX, _posY);

            // Set up the tile buffer to only show tiles on start
            _control.LoadImages(ContentResources.Water, null, null, null);

            parent.Controls.Add(_control);
        }
    }
}
