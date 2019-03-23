using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositioryLayer.Interfaces
{
    public interface IStateRepository
    {
        void SaveState(State state);
        void CreateInitData();
    }
}
