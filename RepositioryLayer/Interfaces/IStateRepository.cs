using DataLayer;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositioryLayer.Interfaces
{
    public interface IStateRepository : IDataRepository<State>
    {
        void SaveState(State state);
        void CreateInitData();
        int GetNextState(int currentStateId);
    }
}
