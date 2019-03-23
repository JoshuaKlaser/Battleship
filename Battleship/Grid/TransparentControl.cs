using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship.Grid
{
    public class TransparentControl : Control
    {
        private readonly Timer refresher;

        private Image _water;
        private Image _status;
        private Image _ship;
        private Image _cantPlace;

        public TransparentControl()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            refresher = new Timer();
            refresher.Interval = 50;
            refresher.Enabled = true;
            refresher.Start();
        }

        // This function acts as a permanent buffer to tell the control what to render.
        public void LoadImages(Image water, Image status, Image ship, Image cantPlace)
        {
            _water = water;
            _status = status;
            _ship = ship;
            _cantPlace = cantPlace;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // I wish I realised when I started that you couldn't create transparent controls in winforms.
            // This was quite the ride to get this working.

            if (_water != null)
            {
                e.Graphics.DrawImage(_water, (Width / 2) - (_water.Width / 2), (Height / 2) - (_water.Height / 2));
            }

            if (_status != null)
            {
                e.Graphics.DrawImage(_status, (Width / 2) - (_status.Width / 2), (Height / 2) - (_status.Height / 2));
            }

            if (_ship != null)
            {
                e.Graphics.DrawImage(_ship, (Width / 2) - (_ship.Width / 2), (Height / 2) - (_ship.Height / 2));
            }

            if (_cantPlace != null)
            {
                e.Graphics.DrawImage(_cantPlace, (Width / 2) - (_cantPlace.Width / 2), (Height / 2) - (_cantPlace.Height / 2));
            }
        }
    }
}
