using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class RelearnCommand : ICommand
    {
        Clone clone;

        public RelearnCommand(Clone clone) 
        {
            this.clone = clone;
        }

        public string Execute()
        {
            clone.Relearn();
            return null;
        }
    }
}
