using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Time.Table.Management.Dtos
{
    public class CommandCreateDto
    {
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
    }
}
