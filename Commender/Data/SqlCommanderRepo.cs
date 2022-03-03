using Commender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commender.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        //Deoedency Injection our DBContext
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Commands.Add(obj);
        }

        public void DeleteCommand(Command obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Commands.Remove(obj);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList(); //ToList return all the List of commands
        }

        public Command GetCommandByID(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0);
        }

       public void UpdateCommand(Command obj)
        {
          if(obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Commands.Remove(obj);
        }
    }
}
