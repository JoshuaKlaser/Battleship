using Battleship.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Content
{
    public class ContentResources
    {
        public static Image Water { get; private set; }
        public static Image Hit { get; private set; }
        public static Image MissedShot { get; private set; }
        public static Image CantPlace { get; private set; }
        public static Image ShipPiece { get; private set; }

        public static void LoadImages()
        {
            Water = Image.FromFile(FileHelper.GetExecutableFilePath("\\Content\\Water.jpg"));
            Hit = Image.FromFile(FileHelper.GetExecutableFilePath("\\Content\\Hit.png"));
            MissedShot = Image.FromFile(FileHelper.GetExecutableFilePath("\\Content\\MissedShot.png"));
            CantPlace = Image.FromFile(FileHelper.GetExecutableFilePath("\\Content\\CantPlace.png"));
            ShipPiece = Image.FromFile(FileHelper.GetExecutableFilePath("\\Content\\ShipPiece.png"));
        }
    }
}

