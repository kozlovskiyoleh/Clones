using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class LearnCommand: ICommand
    {
        private Request request;
        private Dictionary<int, Clone> armyClones;

        public LearnCommand(Dictionary<int, Clone> armyClones, Request request) 
        {
            this.armyClones = armyClones;
            this.request = request;
        }

        public string Execute()
        {
            if (!armyClones.ContainsKey(request.Receiver))
                armyClones.Add(request.Receiver, new Clone());
            armyClones[request.Receiver].Learn(request.Program);
            return null;
        }
    }
}
