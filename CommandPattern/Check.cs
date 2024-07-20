using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones.CommandPattern
{
    public class Check : ICommand
    {
        private readonly Clone clone;

        public Check(Clone clone) 
        {
            this.clone = clone;
        }

        public void Execute()
        {
            clone.Check();
        }
    }
}
