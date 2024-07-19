using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class Clone
    {
        private string _currentProgram = string.Empty;
        private LinkedList<string> _learnedPrograms = new();
        private LinkedList<string> _rollBackPrograms = new();

        public Clone()
        {
            _currentProgram = "basic";
            _learnedPrograms.AddFirst(_currentProgram);
        }

        public Clone(LinkedList<string> learnedPrograms, LinkedList<string> rollBackPrograms)
        {
            _currentProgram = learnedPrograms.First.Value;
            _learnedPrograms =  new LinkedList<string>(learnedPrograms.Reverse());
            _rollBackPrograms = new LinkedList<string>(rollBackPrograms.Reverse());
        }

        public LinkedList<string> GetLearnedPrograms() => _learnedPrograms;

        public LinkedList<string> GetRollBackPrograms() => _rollBackPrograms;

        public string Check() => _currentProgram;

        public void Learn(string program)
        {
            _currentProgram = program;
            _learnedPrograms.AddFirst(program);
        }

        public void RollBack()
        {
            string programToRollback = _learnedPrograms.First.Value;
            _rollBackPrograms.AddFirst(programToRollback);
            _learnedPrograms.Remove(_currentProgram);
            _currentProgram = _learnedPrograms.First.Value;
        }

        public void Relearn()
        {
            _currentProgram = _rollBackPrograms.First.Value;
            _learnedPrograms.AddFirst(_currentProgram);
            _rollBackPrograms.Remove(_currentProgram);
        }
    }
}
