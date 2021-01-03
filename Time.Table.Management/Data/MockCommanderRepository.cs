using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Time.Table.Management.Models;

namespace Time.Table.Management.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
           var commands = new List<Command>
           {
                new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Knife & chopping board" },
                new Command { Id = 2, HowTo = "Make Cup of Tea", Line = "Place tea bag in cup", Platform = "Kettle & Cup" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
