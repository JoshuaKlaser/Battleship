using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship.Grid
{
    public class GridDisplay
    {
        List<List<GridTile>> _tiles = null;
        Control _parent = null;

        public GridDisplay(Control control)
        {            
            _parent = control;
        }

        public void GenerateGrid()
        {
            _tiles = new List<List<GridTile>>();

            for (int i = 0; i < 10; i++)
            {
                var tileRow = new List<GridTile>();

                for (int q = 0; q < 10; q++)
                {
                    var tile = new GridTile(i * 64, q * 64, _parent);
                    tileRow.Add(tile);
                }

                _tiles.Add(tileRow);
            }
        }
    }
}
