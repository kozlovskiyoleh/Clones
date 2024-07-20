using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class Learn : ICommand
    {
        private readonly Clone clone;
        private readonly string program;

        public Learn(Clone clone, string program)
        {
            this.clone = clone;
            this.program = program;
        }

        public void Execute()
        {
            clone.Learn(program);
        }
    }
}
