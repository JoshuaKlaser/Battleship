using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLayer.Models
{
    public class ShipPoint
    {
        public int ShipId { get; private set; }
        public int ShipPieceId { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public bool Hit { get; set; }
        public bool Missed { get; set; }

        public ShipPoint(int shipId, int shipPieceId, int x, int y, bool hit, bool missed)
        {
            ShipId = shipId;
            ShipPieceId = shipPieceId;
            X = x;
            Y = y;
            Hit = hit;
            Missed = missed;
        }
    }
}
