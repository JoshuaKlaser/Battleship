using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Enums
{
    public enum StateEnum { Player1Name = 1, Player1Place, Player2Name, Player2Place, PlayerAttack, Finished}
    public enum ShipOrientation { Broken = 0, SinglePiece, Horizontal, Vertical }
    public enum TileStatus { Nothing = 0, Missed, Hit }
}
