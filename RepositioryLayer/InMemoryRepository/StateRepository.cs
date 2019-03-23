using DataLayer;
using DataLayer.Contexts;
using DataLayer.Repositories;
using RepositioryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositioryLayer.InMemoryRepository
{
    public class StateRepository : DataRepository<State>, IStateRepository
    {
        public StateRepository(string dbName) : this(new BattleshipContext(OptionsBuilder.GetInMemoryOptions(dbName))) { }

        public StateRepository(BattleshipContext context) : base(context) { }

        public void SaveState(State state)
        {
            _dbContext.States.Add(state);
            _dbContext.SaveChanges();
        }

        public void CreateInitData()
        {
            _dbContext.States.Add(new State() { Id = 1, StateName = "Player 1 Choose Name" });
            _dbContext.States.Add(new State() { Id = 2, StateName = "Player 1 Place Pieces", PreviousStateId = 1 });
            _dbContext.States.Add(new State() { Id = 3, StateName = "Player 2 Choose Name", PreviousStateId = 2 });
            _dbContext.States.Add(new State() { Id = 4, StateName = "Player 2 Place Pieces", PreviousStateId = 3 });
            _dbContext.States.Add(new State() { Id = 5, StateName = "Player 1 Makes Move", PreviousStateId = 4 });
            _dbContext.States.Add(new State() { Id = 6, StateName = "Player 2 Makes Move", PreviousStateId = 5 });

            _dbContext.SaveChanges();
        }

        public int GetNextState(int currentStateId)
        {
            if (currentStateId == (int)Shared.Enums.StateEnum.Player1Move)
                return (int)Shared.Enums.StateEnum.Player2Move;

            if (currentStateId == (int)Shared.Enums.StateEnum.Player2Move)
                return (int)Shared.Enums.StateEnum.Player1Move;

            var state = _dbContext.States.Where(s => s.PreviousStateId == currentStateId).FirstOrDefault();

            return state.Id;
        }
    }
}
