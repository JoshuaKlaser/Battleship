﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositioryLayer.Interfaces
{
    public interface IShipPieceRepository
    {
        void SaveShipPiece(ShipPiece piece);
    }
}
