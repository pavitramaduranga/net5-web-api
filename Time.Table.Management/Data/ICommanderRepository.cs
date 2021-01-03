using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Time.Table.Management.Models;

namespace Time.Table.Management.Data
{
    public interface ICommanderRepository
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);
    }
}
