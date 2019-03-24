using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Game
{
    public class Ship
    {
        public Point StartPoint { get; private set; }
        public Point EndPoint { get; private set; }
        public ShipOrientation Orientation { get; private set; }

        private List<Point> _pieces;

        public Ship(int startX, int startY, int endX, int endY)
        {
            _pieces = new List<Point>();

            StartPoint = new Point(startX, startY);
            EndPoint = new Point(endX, endY);
            Orientation = ShipOrientation.Broken;

            if (StartPoint.X == EndPoint.X && StartPoint.Y == EndPoint.Y)
            {
                _pieces.Add(StartPoint);
                Orientation = ShipOrientation.SinglePiece;
            }

            if (Orientation == ShipOrientation.Broken)
                ProcessPoints();
        }

        private void ProcessPoints()
        {
            Point lowestStartPoint;
            Point lowestEndPoint;

            if (StartPoint.X == EndPoint.X)
            {
                Orientation = ShipOrientation.Vertical;

                if (StartPoint.Y < EndPoint.Y)
                {
                    lowestStartPoint = StartPoint;
                    lowestEndPoint = EndPoint;
                }
                else
                {
                    lowestStartPoint = EndPoint;
                    lowestEndPoint = StartPoint;
                }

                for (int i = lowestStartPoint.Y; i <= lowestEndPoint.Y; i++)
                {
                    _pieces.Add(new Point(lowestStartPoint.X, i));
                }
            }
            else
            {
                Orientation = ShipOrientation.Horizontal;

                if (StartPoint.X < EndPoint.X)
                {
                    lowestStartPoint = StartPoint;
                    lowestEndPoint = EndPoint;
                }
                else
                {
                    lowestStartPoint = EndPoint;
                    lowestEndPoint = StartPoint;
                }

                for (int i = lowestStartPoint.X; i <= lowestEndPoint.X; i++)
                {
                    _pieces.Add(new Point(i, lowestStartPoint.Y));
                }
            }
        }

        public List<Point> GetShipPoints()
        {
            return _pieces;
        }
    }
}
