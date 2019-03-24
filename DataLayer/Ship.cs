using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Ship : BaseDataClass
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public ICollection<ShipPiece> ShipPieces { get; set; }
    }
}
