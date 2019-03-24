using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ShipPiece : BaseDataClass
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public bool IsHit { get; set; }
        public bool IsMissed { get; set; }
    }
}
