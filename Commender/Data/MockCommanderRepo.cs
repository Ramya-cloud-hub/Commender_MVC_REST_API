using Commender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commender.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, HowTo = "boil an chicken", Line = "Boil water", Platform = "pan" },
                new Command { Id = 2, HowTo = "Cut bread", Line = "Get the Knife", Platform = "Snadwitch maker" },
                new Command { Id = 3, HowTo = "cut the fruits", Line = "take board", Platform = "bowel" }
            };

           return commands;
        }

     public Command GetCommandByID(int id)
        {
            return new Command { Id = 1, HowTo = "boil an chicken", Line = "Boil water", Platform = "pan" };
        }

        void ICommanderRepo.CreateCommand(Command obj)
        {
            throw new NotImplementedException();
        }

        void ICommanderRepo.DeleteCommand(Command obj)
        {
            throw new NotImplementedException();
        }

        bool ICommanderRepo.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void ICommanderRepo.UpdateCommand(Command obj)
        {
            throw new NotImplementedException();
        }
    }
}
