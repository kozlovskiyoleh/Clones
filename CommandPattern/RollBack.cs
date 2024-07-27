using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class RollBackCommand : ICommand
    {
        Clone clone;

        public RollBackCommand(Clone clone) 
        {
            this.clone = clone;
        }

        public string Execute()
        {
            clone.RollBack();
            return null;
        }
    }
}
