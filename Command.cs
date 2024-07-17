using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class Command
    {
        public string TypeCommand { get;}
        public string Receiver { get;}
        public string Program { get;}

        //TODO query must transform here in Command
        public Command(string query)
        {
            TypeCommand = typeCommand
            Receiver = receiver;
            Program = program;
        }
    }
}
