using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class LearnCommand: ICommand
    {
        Clone clone;
        public LearnCommand(Clone clone) 
        {
            this.clone = clone;
        }

        public string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
