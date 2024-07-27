using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class CloneCommand : ICommand
    {
        CloneVersionSystem _versionSystem;

        public CloneCommand(CloneVersionSystem versionSystem)
        {
            _versionSystem = versionSystem;
        }

        public string Execute()
        {
            _versionSystem.CreateNewClone();
            return null;
        }
    }
}
