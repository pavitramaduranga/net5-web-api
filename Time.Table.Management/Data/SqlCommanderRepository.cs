using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Time.Table.Management.Models;

namespace Time.Table.Management.Data
{
    public class SqlCommanderRepository : ICommanderRepository
    {
        public CommanderContext _context { get; }
        public SqlCommanderRepository(CommanderContext commanderContext)
        {
            _context = commanderContext;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public void CreateCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            _context.Add(command);

        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
