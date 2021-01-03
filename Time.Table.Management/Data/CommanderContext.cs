using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Time.Table.Management.Models;

namespace Time.Table.Management.Data
{
    public class CommanderContext: DbContext
    {
        public CommanderContext(DbContextOptions <CommanderContext> opt) : base(opt)
        {

        }
        public DbSet<Command> Commands { get; set; }
    }
}
