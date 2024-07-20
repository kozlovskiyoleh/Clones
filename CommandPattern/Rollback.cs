using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones.CommandPattern
{
    public class Rollback : ICommand
    {
        private readonly Clone clone;

        public Rollback(Clone clone) 
        {
            this.clone = clone;
        }
        public void Execute()
        {
            clone.RollBack();
        }
    }
}
