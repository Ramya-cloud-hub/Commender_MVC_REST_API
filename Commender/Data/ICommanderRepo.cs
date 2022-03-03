using Commender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commender.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
       public IEnumerable<Command> GetAllCommands();
       public Command GetCommandByID(int id);
       void CreateCommand(Command obj);
       void UpdateCommand(Command obj);
       void DeleteCommand(Command obj);
    }

}
