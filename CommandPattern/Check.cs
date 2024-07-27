using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class CheckCommand : ICommand
    {
        Clone clone;

        public CheckCommand(Clone clone) 
        {
            this.clone = clone;
        }

        public string Execute()
        {
            return clone.Check();
        }
    }
}
