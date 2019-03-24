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
        public delegate void MouseEvent();

        private readonly Timer refresher;

        private Image _water;
        private Image _status;
        private Image _ship;
        private Image _cantPlace;
        private Image _canPlace;
        private MouseEvent _onEnter;
        private MouseEvent _onLeave;
        private MouseEvent _onClick;

        public bool EnableHoverEvents;

        public TransparentControl(MouseEvent onEnter, MouseEvent onLeave, MouseEvent onClick)
        {
            _onEnter = onEnter;
            _onLeave = onLeave;
            _onClick = onClick;

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            refresher = new Timer();
            refresher.Interval = 50;
            refresher.Enabled = true;
            refresher.Start();

            EnableHoverEvents = false;

            this.MouseEnter += TransparentControl_MouseEnter;
            this.MouseLeave += TransparentControl_MouseLeave;
            this.MouseClick += TransparentControl_MouseClick;
        }

        private void TransparentControl_MouseEnter(object sender, EventArgs e)
        {
            if (EnableHoverEvents)
            {
                _onEnter();
            }
        }

        private void TransparentControl_MouseLeave(object sender, EventArgs e)
        {
            if (EnableHoverEvents)
            {
                _onLeave();
            }
        }

        private void TransparentControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (EnableHoverEvents)
            {
                _onClick();
            }
        }

        // This function acts as a permanent buffer to tell the control what to render.
        public void LoadImages(Image water, Image canPlace, Image status, Image ship, Image cantPlace)
        {
            _water = water;
            _status = status;
            _ship = ship;
            _cantPlace = cantPlace;
            _canPlace = canPlace;

            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // I wish I realised when I started that you couldn't create transparent controls in winforms.
            // This was quite the ride to get this working.

            e.Graphics.Clear(Color.LightSkyBlue);

            if (_water != null)
            {
                e.Graphics.DrawImage(_water, (Width / 2) - (_water.Width / 2), (Height / 2) - (_water.Height / 2));
            }

            if (_status != null)
            {
                e.Graphics.DrawImage(_status, (Width / 2) - (_status.Width / 2), (Height / 2) - (_status.Height / 2));
            }

            if (_canPlace != null)
            {
                e.Graphics.DrawImage(_canPlace, (Width / 2) - (_canPlace.Width / 2), (Height / 2) - (_canPlace.Height / 2));
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
