using DataLayer;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositioryLayer.Interfaces
{
    public interface IPlayerRepository : IDataRepository<Player>
    {
        void SavePlayer(Player player);
        int CreatePlayer(string name);
    }
}
